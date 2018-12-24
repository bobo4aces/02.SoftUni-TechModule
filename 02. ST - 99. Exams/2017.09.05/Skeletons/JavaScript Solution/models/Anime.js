const mongoose = require('mongoose');

let animeSchema = mongoose.Schema({
    //TODO: Implement me ...
});

let Anime = mongoose.model('Anime', animeSchema);

module.exports = Anime;