const encryption = require("../utilities/encryption");
const User = require('../models').User;
const Article = require('../models').Article;
module.exports = {
    registerGet: (req, res) => {
        res.render('user/register');
    },
    updateGet: (req, res) => {
        let args = req.body;
        let id = req.params.id;

        User.findById(id).then(user=>{
            res.render('user/details',user.dataValues)
        });
    },
        updatePost: (req, res) => {
            let id = req.body.originalname;
            let updateInfo = req.body;
            let salt = encryption.generateSalt();
            let passwordHash = encryption.hashPassword(updateInfo.password, salt);
            let userObject = {
                email: updateInfo.email,
                passwordHash: passwordHash,
                fullName: updateInfo.fullName,
                salt: salt
            };
            User.findById(id).then(user => {
                console.log(user);
                user.update(userObject)
            }).catch(e => {


                }
            );
            res.redirect('/');
            console.log(id)

    },
    registerPost: (req, res) => {
        let registerArgs = req.body;
let id = req.params.id;
        User.findOne({where: {email: registerArgs.email}}).then(user => {
            let errorMsg = '';
            if (user) {
                errorMsg = 'User with the same username exists!';
            } else if (registerArgs.password !== registerArgs.repeatedPassword) {
                errorMsg = 'Passwords do not match!'
            }

            if (errorMsg) {
                registerArgs.error = errorMsg;
                res.render('user/register', registerArgs)
            } else {

                let salt = encryption.generateSalt();
                let passwordHash = encryption.hashPassword(registerArgs.password, salt);

                let userObject = {
                    email: registerArgs.email,
                    passwordHash: passwordHash,
                    fullName: registerArgs.fullName,
                    salt: salt
                };

                User.create(userObject).then(user => {
                    req.logIn(user, (err) => {
                        if (err) {
                            registerArgs.error = err.message;
                            res.render('user/register', registerArgs.dataValues);
                            return;
                        }
                        res.redirect('/')
                    })
                })
            }
        })
    },

    loginGet: (req, res) => {
        res.render('user/login');
    },

    loginPost: (req, res) => {
        let loginArgs = req.body;
        User.findOne({where: {email: loginArgs.email}}).then(user => {
            if (!user || !user.authenticate(loginArgs.password)) {
                loginArgs.error = 'Either username or password is invalid!';
                console.log("loginPost error");
                res.render('user/login', loginArgs);
                return;
            }

            req.logIn(user, (err) => {
                if (err) {
                    res.redirect('user/login', {error: err.message});
                    console.log('login error');
                    return;
                }

                res.redirect('/');
            })
        })
    },

    logout: (req, res) => {
        req.logOut();
        res.redirect('/');
    },
    UDetails: (req, res) => {
        let id = req.params.id;
        User.findById(id, {
            include: [{
                model: Article
            }]
        }).then(User => {
            res.render('user/details', User.dataValues);
        })
    }
};