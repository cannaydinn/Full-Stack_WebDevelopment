import './App.css';
import { useState } from 'react';
import { useEffect } from 'react';
import Header from './Components/HeaderSection/header'
import Content from './Components/ContentSection/content'
import Receipt from './Components/ReceiptSection/receipt.jsx';
import products from './Data.js';

function App() {
  const [money, setMoney] = useState(100000000000);
  const [purchasedProducts, setPurchasedProducts] = useState([]);
  const [total, setTotal] = useState(0);

  const handleBuy = (product) => {
    const productIndex = purchasedProducts.findIndex(
      (purchasedProduct) => purchasedProduct.name === product.name
    );

    if (productIndex === -1) {
      setPurchasedProducts([...purchasedProducts, { ...product, quantity: 1 }]);
    } else {
      const updatedProducts = [...purchasedProducts];
      updatedProducts[productIndex].quantity += 1;
      setPurchasedProducts(updatedProducts);
    }
    const totalPrice = purchasedProducts.reduce((total, product) => {
      return total + product.price * product.quantity;
    }, 0);
    setTotal(totalPrice);
  };

  useEffect(() => {
    const newTotalPrice = purchasedProducts.reduce((total, product) => {
      return total + product.price * product.quantity;
    }, 0);

    setTotal(newTotalPrice);
  }, [purchasedProducts]);


  const handleSell = (product) => {
    const productIndex = purchasedProducts.findIndex(
      (purchasedProduct) => purchasedProduct.name === product.name
    );

    if (productIndex !== -1) {
      const updatedProducts = [...purchasedProducts];

      if (updatedProducts[productIndex].quantity > 1) {
        updatedProducts[productIndex].quantity -= 1;
      } else {
        updatedProducts.splice(productIndex, 1);
      }

      setPurchasedProducts(updatedProducts); 
    }
  };

  return (
    <>
        <Header money={money}/>
        <div className="container w-full mt-2">
          <div className="grid grid-cols-1 sm:grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4">
            {products.map((product) => (
              <Content
                key={product.id}
                product={product}
                money={money}
                setMoney={setMoney}
                handleBuy={handleBuy}
                handleSell={handleSell}
              />
            ))}
          </div>
        </div>
        <Receipt purchasedProducts={purchasedProducts} total={total} />
        
    </>
  );
}

export default App
