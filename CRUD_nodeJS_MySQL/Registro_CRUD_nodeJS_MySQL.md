# Aplicación CRUD con JS, nodesJs y MySQL

1. ###### Primero inicializar proyecto con nodeJS (obviamente instalar nodeJS primero):

    >npm init --yes 

    Crea el archivo **package.json** que es donde se reflejara todo lo relacionado en el proyecto.

2. ###### Instalar las dependencias:
    * **[express](https://expressjs.com/es/guide/routing.html)**: Express será una ayuda para escibir menos codigo de nodeJS ya que dará funciones que ya están probadas y que por lo tanto no patinaras al inventartelas :smile:.
    * **[mysql](https://www.npmjs.com/package/mysql)**: será una manera de conectar el codido de *express* con MySQL
        * PD: con *express* y *mysql* ya se podría hcer el servidor que se conecte a MySQL sin problemas.
    * **[express-myconnection](https://www.npmjs.com/package/express-myconnection)**:  Con la siguiente dependencia se podrá usar la conexión de *mysql* en los middlewars de *express* para tener a mano la conexión de mysql mientras picas codigo con ello podrás acceder a las operaciones CRUD almacenadas.
    * **[morgan](https://www.npmjs.com/package/morgan)**: Permite ver las peticiones al servidor.
    * **[ejs](https://ejs.co/)**: Motor de plantillas, podrás enviar htmls al servidor previamente procesados por el servidor, así uno podra ejecurar condicioneales, bucles... para utilizar logica de programación para diseñar el html y ya luego procesarlo en el servidor y enviarlo al cliente (creo ? :sweat_smile:).

    >npm install express mysql express-myconnection morgan ejs
   
   >1. ###### Bonus
        >* **[nodemon](https://nodemon.io)**: Este es el plugin de la vagueza, se encargara de reiniciar el server cadavez que haya cambios.
        >    * PD: Instalo **nodemon** con *-D* para que no se instale como dependencia esencial si no  como ayuda al desarollo (Esto se vera reflejado en el archivho de packages.json aparecera como devDependencies).
        >
        >>npm install nodemon -D 
        >
        >Se puede configurar un script para ejecutar modemon como si estuviera instalado de forma global.
        En package.json en la zona de *script* añadir esta linea:
        
    ```json
    "scripts": {
        "server": "nodemon ./src/server_main.js" 
    }
    ```
    

3. ###### Preparar el servidor:
    1. Lo primero será requerir express, inicializarlo, definir una seción para configurar express y poner el servidor a escuchar.
        ```js
        const express = require('express');
        const app = express();

        //EXPRESS SETTINGS 

        //Esta linea lo que hace es coger el puerto que proporciona el servidor en el caso de lo 
        //proporcione pero si el servidor no proporciona ningún pruerto pues cogera el puerto 3000
        app.set('port', process.env.PORT || 3000);

        app.listen(app.get('port'), () => {
            console.log('escuchando en el puerto 3000');
        });
        ```
        Ahora a ver si no se ha pifiado hasta ahora:
        >npm run server
    2. Lo siguiente será refinir la ruta de las vistas a nuestro motor de plantillas *ejs*:
        ```js
        const path = require('path');

        //express settings 
        app.set('view engine', 'ejs');
        app.set('views', path.join(__dirname, 'views'));
        ```
    3. Para una primera configuración de *morgan* ahrémos que nos de información útil cada vez que un cliente hace peticiones al servidor.
        ```js
        const morgan = require('morgan');

        //MIDDLEWARES
        app.use(morgan('dev'))
        ```
    4. Lo siguiente será editar los datos de la BBDD.
        ```js
        const mysql = require('mysql');
        const myConnection = require('express-myconnection');

        //MIDDLEWARES
        app.use(myConnection(mysql, {
            host: 'localhost',
            user: 'root',
            password: 'root',
            port: 3306,
            database: 'crud_nodejs_mysql'
        }, 'single'));
        ```
        También crearé una carpeta en la que guardare los scripst.
        ```sql
        -- to create a new database
        CREATE DATABASE crud_nodejs_mysql;

        -- to use database
        use crud_nodejs_mysql;

        -- creating a new table
        CREATE TABLE user (
        id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
        name VARCHAR(50) NOT NULL,
        address VARCHAR(100) NOT NULL,
        phone VARCHAR(15)
        );

        -- to show all tables
        show tables;

        -- to describe table
        describe user;
        ```
    5. Ahora definiremos las rutas a las que se harán peticones.
        * Primero se creará la carpeta de rutas que hará de modelo en un proyecto modelo vista controlador y dentro de creara el archivo js donde se gestionarán las peticiones y respuestas:
            ```js
            const express = require('express');
            const router = express.Router();

            //Traigo la logica que hay detras de cada llamada 
            //para poder responder con el metodo apropiado a la petición
            const userController = require('../controllers/userController');

            //Cuando recibas una petición a la ruta inicial del servidor "/" 
            //devolvere el metodo "list" del objeto "userController"
            router.get('/', userController.list);

            module.exports = router;
            ```
        * Ahora hay que definir en *userController.js* la logica que hará destras de cada respuesta.
            ```js
            const controller = {};

            controller.list = (req, res) => {
                res.send('helloWorld');
            };

            module.exports = controller;
            ```

        * Por último no olvidar importar las rutas de los usuarios al *server_main.js*
            ```js
            //IMPORTING ROUTES
            const userRoute = require('./routes/user');


            //ROUTES
            //Cada vez que un usuario llegue a la ruta principal "/" ejecuta estas rutas llamadas "userRoutes"
            app.use('/', userRoute);
            ```
    6. Este así ha quedado el archivo main del servidor *server_main.js*
        ```js
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
        app.set('view engine', 'ejs');
        app.set('views', path.join(__dirname, 'views'));

        //MIDDLEWARES
        app.use(morgan('dev'));
        app.use(myConnection(mysql, {
            host: 'localhost',
            user: 'root',
            password: 'root',
            port: 3306,
            database: 'crud_nodejs_mysql'
        }, 'single'));

        //ROUTES
        app.use('/', userRoute);

        //STATIC FILES
        app.use(express.static(path.join(__dirname, 'public')));

        //STARTING SERVER
        app.listen(app.get('port'), () => {
            console.log('escuchando en el puerto 3000');
        });
        ```
        