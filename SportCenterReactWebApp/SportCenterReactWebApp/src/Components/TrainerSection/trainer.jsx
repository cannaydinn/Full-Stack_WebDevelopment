import "./trainer.css"

function Trainer() {
  return (
    <>
        <section className="section section-ice-blue" id="trainer">
        <div className="container">
            <div className="section-title">
                <h3>OUR BEST TRAINERS</h3>
                <div className="orange-line"></div>
                <div className="text">
                    <p>Lorem Ipsum is not simply random text. It has roots in a piece of classical at Hampden-Sydney Collage</p>
                </div>
            </div>
            <div className="section-content">
                <div className="row">
                  <div className="col-3 trainer-card">
                    <div className="cardio-banner"></div>
                    <img src="src/assets/images/trainer1.jpg" alt="Trainer 1" className="img-fluid"/>
                    <div className="cardio-content">
                        <h2>Emily Clark</h2>
                        <p>Yoga Trainer</p>
                    </div>
                  </div>
                  <div className="col-3 trainer-card">
                    <div className="cardio-banner"></div>
                    <img src="src/assets/images/trainer2.jpg" alt="Trainer 2" className="img-fluid"/>
                    <div className="cardio-content">
                      <h2>John Smith</h2>
                      <p>Strength Trainer</p>
                    </div>
                  </div>
                  <div className="col-3 trainer-card">
                    <div className="cardio-banner"></div>
                    <img src="src/assets/images/trainer3.jpg" alt="Trainer 3" className="img-fluid"/>
                    <div className="cardio-content">
                      <h2>Jane Doe</h2>
                      <p>Cardio Trainer</p>
                    </div>
                  </div>
                </div>
              </div>
              
        </div>
    </section>
    </>
    
  )
}

export default Trainer