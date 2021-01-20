const express = require('express');
const path = require('path');
const morgan = require('morgan');
const mysql = require('mysql');
const myConnection = require('express-myconnection');

const app = express();

//IMPORTING ROUTES
const userRoute = require('./routes/user');

//EXPRESS SETTINGS 
app.set('port', process.env.PORT || 3000);
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'ejs');

//MIDDLEWARES
app.use(morgan('dev'));
app.use(myConnection(mysql, {
    host: 'localhost',
    user: 'root',
    password: 'root',
    port: 3306,
    database: 'crud_nodejs_mysql'
}, 'single'));
app.use(express.urlencoded({ extended: false }));

//ROUTES
app.use('/', userRoute);

//STATIC FILES
app.use(express.static(path.join(__dirname, 'public')));

//STARTING SERVER
app.listen(app.get('port'), () => {
    console.log(`escuchando en el puerto ${app.get('port')}`);
});