import { useState } from "react";

function Content({product, money, setMoney, handleBuy, handleSell}) {
  const [quantity, setQuantity] = useState(0);

  const buyProduct = () => {
    if (product.price <= money) {
      setQuantity(quantity + 1);
      setMoney(money - product.price);
    } else {
      alert("Not enough balance to buy this product!");
    }
  };

  const sellProduct = () => {
    if (quantity > 0) {
      setMoney(money + product.price);
      setQuantity(quantity - 1);
    } else {
      alert("Please enter a valid quantity to sell.");
    }
  };

  return (
    <div className="w-full bg-white flex flex-col items-center justify-between py-4 px-4 border border-gray-200 shadow-md">
      <img
        className="max-w-full h-auto object-content"
        src={product.img}
        alt={product.name}
      />

      <h5 className="mt-4 mb-2 text-xl font-bold tracking-tight text-gray-900">
        {product.name}
      </h5>
      <h6 className="mb-4 text-lg font-medium text-gray-600">
        ${product.price.toLocaleString("en-US")}
      </h6>
      <div className="flex items-center justify-center gap-2 w-full">
        <button
          onClick={() => {
            sellProduct();
            handleSell(product);
          }}
          className={`sell-button w-1/3 py-2 px-8 rounded-sm ${
            quantity > 0 ? "bg-red-500" : "bg-gray-400"
          }`}
          disabled={quantity <= 0}
        >
          Sell
        </button>
        <input
          className="border w-1/3 border-gray-400 py-2 text-center"
          type="text"
          value={quantity}
          onChange={(e) => setQuantity(Number(e.target.value))}
        />
        <button
          onClick={() => {
            buyProduct();
            handleBuy(product);
          }}
          className="buy-button w-1/3 bg-green-500 text-white py-2 px-8 rounded-sm"
        >
          Buy
        </button>
      </div>
    </div>
  );
}

export default Content