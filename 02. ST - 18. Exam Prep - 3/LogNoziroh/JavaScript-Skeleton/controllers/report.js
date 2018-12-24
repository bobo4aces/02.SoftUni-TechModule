const Report = require('../models').Report;

module.exports = {
    index: (req, res) => {
        //TODO
        let reports = Report.findAll().then(reports=>{
            res.render("report/index", {"reports": reports})
        });

    },
    createGet: (req, res) => {
        //TODO
        res.render("report/create");

    },
    createPost: (req, res) => {
        //TODO
        let args = req.body;
        console.log(args);
        Report.create(args).then(()=>{
            res.redirect("/");
        })

    },
    detailsGet: (req, res) => {
        //TODO
        let id = req.params.id;
        Report.findById(id).then(report => {
            res.render("report/details", report.dataValues);
        })

    },
    deleteGet: (req, res) => {
        //TODO
        let id = req.params.id;

        Report.findById(id).then(report => {
            res.render("report/delete", report.dataValues);
        })


    },
    deletePost: (req, res) => {
        //TODO
        let id = req.params.id;

        Report.findById(id).then(report=>{
            report.destroy().then(()=>{
                res.redirect('/');
            })
        })

    }
};