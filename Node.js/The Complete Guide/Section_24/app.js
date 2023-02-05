const express = require("express");
const app = express();
const bodyParser = require("body-parser");
const feedRoutes = require("./routes/feed");

//app.use(bodyParser.urlencoded()); // x-www-form-urlencoded <form>
app.use(bodyParser.json()); // application/json

app.use("/feed", feedRoutes);

app.listen(8080);
