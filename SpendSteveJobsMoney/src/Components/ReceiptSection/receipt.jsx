function Receipt({ purchasedProducts, total }) {
    return (
      <div className="w-full bg-white flex flex-col items-center py-4 px-96 border border-gray-200 shadow-md mt-2 mb-5">
        <h4 className="text-2xl mb-4">Your Receipt</h4>
        <ul className="w-full">
          {purchasedProducts.length > 0 ? (
            purchasedProducts.map((product, index) => (
              <li key={index} className="flex justify-between w-full px-4 py-2 ">
                <span>
                  {product.name}{" "}
                  {product.quantity > 1 ? `x${product.quantity}` : ""}
                </span>
                <span className="text-emerald-500">
                  ${(product.price * product.quantity).toLocaleString("en-US")}
                </span>
              </li>
            ))
          ) : (
            <li className="">No products purchased yet.</li>
          )}
        </ul>
        <div className="w-full flex flex-col justify-between ">
          <div className="w-full bg-black h-0.5"></div>
          <h3 className="flex justify-between font-bold">
            TOTAL{" "}
            <span className="text-emerald-500">
              ${total.toLocaleString("EN-us")}
            </span>
          </h3>
        </div>
      </div>
    );
  }

  export default Receipt;