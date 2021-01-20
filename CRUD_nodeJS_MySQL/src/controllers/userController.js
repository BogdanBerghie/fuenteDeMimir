const { use } = require("../routes/user");

const controller = {};

//get all users
controller.list = (req, res) => {
    req.getConnection((err, conn) => {
        conn.query('select * from user', (err, users) => {
            if (err) {
                res.json(err);
            };
            console.log(users);
            res.render('users', {
                data: users
            });
        });
    });
};

//add new user
controller.add = (req, res) => {
    const data = req.body;
    console.log(req.body)
    req.getConnection((err, connection) => {
        const query = connection.query('INSERT INTO user set ?', data, (err, user) => {
            console.log(user)
            res.redirect('/');
        })
    })
};

//delete a user
controller.delete = (req, res) => {
    const { id } = req.params;
    req.getConnection((err, connection) => {
        connection.query('DELETE FROM user WHERE id = ?', [id], (err, rows) => {
            res.redirect('/');
        });
    });
};

controller.edit = (req, res) => {
    const { id } = req.params;
    const newUser = req.body;
    req.getConnection((err, conn) => {
        conn.query('UPDATE user set ? where id = ?', [newUser, id], (err, rows) => {
            res.redirect('/');
        });
    });
};


//update a user 
controller.update = (req, res) => {
    const { id } = req.params;
    req.getConnection((err, conn) => {
        conn.query("SELECT * FROM user WHERE id = ?", [id], (err, rows) => {
            res.render('users_edit', {
                data: rows[0]
            })
        });
    });
};

module.exports = controller;