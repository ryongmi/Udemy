const { validationResult } = require("express-validator");

exports.getPosts = (req, res, next) => {
  res.status(200).json({
    posts: [
      {
        _id: "1",
        title: "First Post",
        contents: "This is the first post!",
        imageUrl: "images/ori.jpg",
        creator: {
          name: "TurTle",
        },
        createdAt: new Date(),
      },
    ],
  });
};

exports.createPost = (req, res, next) => {
  const errors = validationResult(req);
  if (!errors.isEmpty()) {
    return res.status(422).json({
      message: "Validation failed, entered data is incorrect",
      errors: errors.array(),
    });
  }
  const title = req.body.title;
  const contents = req.body.contents;
  // create post in db
  res.status(201).json({
    message: "Post created successfully!",
    post: {
      _id: new Date().toDateString(),
      title: title,
      contents: contents,
      creator: {
        name: "TurTle",
      },
      createdAt: new Date(),
    },
  });
};
