const Film = require('../models').Film;

module.exports = {
	index: (req, res) => {
        // TODO
        let films = Film.findAll().then(films=>{
            res.render("film/index", {"films": films})
        });

    },

	createGet: (req, res) => {
        // TODO
        res.render("film/create");

    },

	createPost: (req, res) => {
        // TODO
        let args = req.body;
        console.log(args);
        Film.create(args).then(()=>{
            res.redirect("/");
        })

    },

	editGet: (req, res) => {
        // TODO
        let id = req.params.id;

        Film.findById(id).then(film =>
            res.render("film/edit", film.dataValues));

    },

	editPost: (req, res) => {
        // TODO
        let id = req.params.id;
        let args = req.body;

        Film.findById(id).then(film=>{
            film.updateAttributes(args).then(()=>{
                res.redirect('/');
            })
        })

    },

	deleteGet: (req, res) => {
        // TODO
        let id = req.params.id;

        Film.findById(id).then(film =>
            res.render("film/delete", film.dataValues));

    },

	deletePost: (req, res) => {
        // TODO
        let id = req.params.id;

        Film.findById(id).then(film=>{
            film.destroy().then(()=>{
                res.redirect('/');
            })
        })

    }
};