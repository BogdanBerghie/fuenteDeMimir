const express = require('express');
const app = express();

//express settings 
app.set('port', process.env.PORT || 3000);

app.listen(app.get('port'), () => {
    console.log('escuchando en el puerto 3000');
});