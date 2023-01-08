const mongoose = require("mongoose");
const Schema = mongoose.Schema;

const orderSchema = new Schema({
  products: [
    {
      product: { type: Object, required: true },
      quantity: { type: Number, required: true },
    },
  ],
  user: {
    email: { type: String, required: true },
    userId: {
      type: Schema.Types.ObjectId,
      // ref: 참조할 모델명을 정의
      ref: "User",
      required: true,
    },
  },
});

module.exports = mongoose.model("Order", orderSchema);
