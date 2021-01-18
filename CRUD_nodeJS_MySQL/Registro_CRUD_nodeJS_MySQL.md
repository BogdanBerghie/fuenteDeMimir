#Aplicación CRUD con JS, nodesJs y MySQL

1. ###### Primero inicializar proyecto con nodeJS (obviamente instalar nodeJS primero):

    >npm init --yes 

    Crea el archivo **package.json** que es donde se reflejara todo lo relacionado en el proyecto.

2. ###### Instalar las dependencias:
    * **[express](https://expressjs.com/es/guide/routing.html)**: Express será una ayuda para excibir menos codigo de nodeJS ya que dará funciones que ay están probadas y que por lo tanto no patinaras al inventartelas :).
    * **[mysql](https://www.npmjs.com/package/mysql)**: será una manera de conectar el codido de *express* con MySQL
        * PD: con *express* y *mysql* ya se podría hcer el servidor que se conecte a MySQL sin problemas.
    * **[express-myconnection](https://www.npmjs.com/package/express-myconnection)**:  Con la siguiente dependencia se podrá usar la conexión de *mysql* en los middlewars de *express* para tener a mano la conexión de mysql mientras picas codigo con ello podrás acceder a las operaciones CRUD almacenadas.
    * **[morgan](https://www.npmjs.com/package/morgan)**: Permite ver las peticiones al servidor.
    * **[ejs](https://ejs.co/)**: Motor de plantillas, podrás enviar htmls al servidor previamente procesados por el servidor, así uno podra ejecurar condicioneales, bucles... para utilizar logica de programación para diseñar el html y ya luego procesarlo en el servidor y enviarlo al cliente (creo ? :sweat_smile:).

    >npm install express mysql express-myconnection morgan ejs nodemon

    * **[nodemon](https://nodemon.io/)**: Este es el plugin de la vagueza, se encargara de reiniciar el server cadavez que haya cambios :smirk:.
        * PD: Instalo **nodemon** con *-D* para que no se instale como dependencia esencial si no como ayuda al desarollo.
    >npm install nodemon -D 
    

3. ###### Preparar el servidor:
    1. Lo primero será requerir express, inicializarlo, definir una seción para configurar express y poner el servidor a escuchar.
        ```js
        const express = require('express');
        const app = express();

        //express settings 
        app.set
        
        app.listen(3000, () => {
        console.log('escuchando en el puerto 3000')
        });
        ```
        Ahora a ver si no se ha pifiado hasta ahora:
        >node src/app.js

    

