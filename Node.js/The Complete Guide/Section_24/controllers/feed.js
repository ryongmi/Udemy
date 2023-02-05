exports.getPosts = (req, res, next) => {
  res.status(200).json({
    posts: [{ title: "First Post", contents: "This is the first post!" }],
  });
};

exports.createPost = (req, res, next) => {
  const title = req.body.title;
  const contents = req.body.contents;
  // create post in db
  res.status(201).json({
    message: "Post created successfully!",
    post: { id: new Date().toDateString(), title: title, contents: contents },
  });
};
