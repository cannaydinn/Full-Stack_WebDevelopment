import "./purchase.css";

function Purchase() {
  return (
    <>
        <section className="section section-white">
        <div className="container">
            <div className="section-title">
                <h3>PURCHASE FROM US</h3>
                <div className="orange-line"></div>
                <div className="text">
                    <p>Lorem Ipsum is not simply random text. It has roots in a piece of classical at Hampden-Sydney Collage</p>
                </div>
            </div>
            <div className="section-content mb-5">
                <div className="row">
                    <div className="col-md-3">
                        <div className="card shadow-lg">
                            <img className="card-img-top img-fluid" src="src/assets/images/purchase1.jpg" alt="Card image cap"/>
                            <div className="card-body">
                                <p className="card-text">Kettlebell / 5kg</p>
                                <p className="card-text"> <del>89,99$</del> / 59,99$</p>
                                <p className="card-text"><i className="bi bi-cart-fill"></i> Add To Cart</p>
                            </div>
                        </div>
                    </div>
                    <div className="col-md-3">
                        <div className="card shadow-lg">
                            <img className="card-img-top img-fluid" src="src/assets/images/purchase2.jpg" alt="Card image cap"/>
                            <div className="card-body">
                                <p className="card-text">Treadmill</p>
                                <p className="card-text"> <del>899,99$</del> / 599,99$</p>
                                <p className="card-text"><i className="bi bi-cart-fill"></i> Add To Cart</p>
                            </div>
                        </div>
                    </div>
                    <div className="col-md-3">
                        <div className="card shadow-lg">
                            <img className="card-img-top img-fluid" src="src/assets/images/purchase3.jpg" alt="Card image cap"/>
                            <div className="card-body">
                                <p className="card-text">Adjustable Dumbbell</p>
                                <p className="card-text"> <del>89,99$</del> / 59,99$</p>
                                <p className="card-text"><i className="bi bi-cart-fill"></i> Add To Cart</p>
                            </div>
                        </div>
                    </div>
                    <div className="col-md-3">
                        <div className="card shadow-lg">
                            <img className="card-img-top img-fluid" src="src/assets/images/purchase4.jpg" alt="Card image cap"/>
                            <div className="card-body">
                                <p className="card-text">Kettlebell / 3kg</p>
                                <p className="card-text"> <del>89,99$</del> / 59,99$</p>
                                <p className="card-text"><i className="bi bi-cart-fill"></i> Add To Cart</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    </>
  )
}

export default Purchase