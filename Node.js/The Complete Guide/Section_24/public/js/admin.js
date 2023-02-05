const deleteProduct = (btn) => {
  const productId = btn.parentNode.querySelector("[name=productId]").value;
  const csrf = btn.parentNode.querySelector("[name=_csrf]").value;

  // closest(article) : btn에서 가장 가까운 article DOM을 찾아 반환함
  const productEl = btn.closest("article");

  fetch("/admin/product/" + productId, {
    method: "DELETE",
    headers: {
      "csrf-token": csrf,
    },
  })
    .then((result) => {
      // 백엔드에서 보낸 json 객체를 받아 사용하기 위함
      return result.json();
    })
    .then((data) => {
      console.log(data);
      // 선택된 품목DOM의 부모를 가져와 자식인 품목DOM을 삭제함
      productEl.parentNode.removeChild(productEl);
    })
    .catch((err) => console.log(err));
};
