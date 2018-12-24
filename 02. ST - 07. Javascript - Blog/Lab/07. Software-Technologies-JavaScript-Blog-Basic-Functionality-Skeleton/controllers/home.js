module.exports = {
    index: (req, res) => {

        res.render('home/index');

    }
};
module.exports = {
    index: (req, res) => {
        Article.findAll({limit: 6, include: [{
            model: User
        }]}).then(articles=>{
            res.render('home/index', {articles: articles});
        });
    }
};




