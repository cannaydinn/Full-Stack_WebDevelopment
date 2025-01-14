import "./contact.css";

function Contact() {
  return (
    <>
        <section className="section section-white" id="contact">
        <div className="container">
            <div className="section-title">
                <h3>CONTACT US</h3>
                <div className="orange-line"></div>
                <div className="text">
                    <p>Lorem Ipsum is not simply random text. It has roots in a piece of classical at Hampden-Sydney Collage</p>
                </div>
            </div>
            <div className="row">
                <div className="col-lg-6 col-md-12">
                    <div className="container">
                        <div className="row">
                            <div className="col-6">
                                <div className="contactInfo">
                                    <p>Mobile Number</p>
                                    <p>+135 773 321 4442</p>
                                </div>
                            </div>
                            <div className="col-6">
                                <div className="contactInfo">
                                    <p>Email Address</p>
                                    <p>demo@demo.com</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="contactForm">
                        <p>Make An Appoinment</p>
                        <input type="text" placeholder="Your Name"/>
                        <input type="email" placeholder="Your Email"/>
                        <textarea rows="5" placeholder="Your Message"></textarea>
                    </div>    
                </div>
                <div className="col-lg-6 col-md-12">
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3009.890675978079!2d28.98270567675368!3d41.027647671347715!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab9d81ea6df6f%3A0x915b49a4a47881e7!2sGalataport%20%C4%B0stanbul!5e0!3m2!1str!2str!4v1736104190598!5m2!1str!2str" width="600" height="450" allowfullscreen="" loading="lazy">
                    </iframe>
                </div>
            </div>
        </div>
    </section>
    </>
  )
}

export default Contact