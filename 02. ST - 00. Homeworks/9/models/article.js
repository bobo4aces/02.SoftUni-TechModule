const Sequelize = require("sequelize");

module.exports = function (sequelize) {

    const Article = sequelize.define('Article', {
        title: {
            type: Sequelize.STRING,
            allowNull: false,
            required: true
        },
        content: {
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        date: {
            type: Sequelize.DATE,
            allowNull: false,
            required: true,
            defaultValue: Sequelize.NOW,
        },
        picture: {
            type: Sequelize.STRING,
            allowNull: false,


        }
    });
    Article.associate = function (models) {
        Article.belongsTo(models.User, {
            foreignKey: 'authorId',
            target: 'id'
        });
    };

    return Article;

};