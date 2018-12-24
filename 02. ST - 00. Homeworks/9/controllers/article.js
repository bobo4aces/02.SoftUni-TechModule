const Article = require('../models').Article;
const User = require('../models').User;
module.exports = {
    createGet: (req, res) => {
        res.render('article/create');
    },

    createPost: (req, res) => {
        let args = req.body;
        let error = '';
        if (!req.isAuthenticated()) {
            error = 'You should b logged in to make articles!';

        } else if (!args.title) {
            error = 'Invalid title!';
        } else if (!args.content) {
            error = 'Invalid content!';
        }
        if (error) {
            res.render('article/create', {error: error});
            return;
        }
        args.authorId = req.user.id;

        Article.create(args).then(article => {
            res.redirect('/');
        }).catch(e => {
            console.log(e.message);
            res.render('article/create', {error: e.message});
        })
    },

    Details: (req, res) => {
        let id = req.params.id;
        Article.findById(id, {
            include: [{
                model: User
            }]
        }).then(article => {
            res.render('article/details', article.dataValues);
        });
    }
};