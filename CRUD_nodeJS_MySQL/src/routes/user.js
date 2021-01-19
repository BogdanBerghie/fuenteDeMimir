const express = require('express');
const router = express.Router();

//Traigo la logica que hay detras de cada llamada para poder responder con el metodo apropiado a la petición
const userController = require('../controllers/userController');

//Cuando recibas una petición a la ruta inicial del servidor "/" llamare a un metodo del objeto userController
router.get('/', userController.list);

module.exports = router;