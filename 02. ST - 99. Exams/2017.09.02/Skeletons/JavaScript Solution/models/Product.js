const mongoose = require('mongoose');

let productSchema = mongoose.Schema({
    //TODO: Implement me ...
});

let Product = mongoose.model('Product', productSchema);

module.exports = Product;