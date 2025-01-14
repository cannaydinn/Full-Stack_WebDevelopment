import "./review.css";

function Review() {
  return (
    <>
        <section className="section section-ice-blue" id="review">
        <div className="container">
            <div className="section-title">
                <h3>REVIEW CLIENT</h3>
                <div className="orange-line"></div>
                <div className="text">
                    <p>Lorem Ipsum is not simply random text. It has roots in a piece of classical at Hampden-Sydney Collage</p>
                </div>
            </div>
            <div className="section-content">
                <div className="row gy-4">
                    <div className="col-md-6">
                        <div className="review-card">
                            <div className="review-header d-flex align-items-center mb-3">
                                <img src="src/assets/images/client1.jpg" alt="Diet Expert" className="rounded-circle me-3" width="64" height="64"/>
                                <div>
                                    <p className="review-name fw-bold mb-0">Diet Expert</p>
                                    <p className="review-title text-muted mb-0">CFO</p>
                                </div>
                            </div>
                            <div className="review-text text-white p-3 ">
                                <p className="mb-0">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit. Nulla, sequi quia, libero voluptatibus ducimus earum quidem minus eveniet, ex esse rem sed numquam. Error magnam in vero molestiae tempora nostrum.
                                </p>
                            </div>
                        </div>
                    </div>
                    <div className="col-md-6">
                        <div className="review-card">
                            <div className="review-header d-flex align-items-center mb-3">
                                <img src="src/assets/images/client2.jpg" alt="Cardio Trainer" className="rounded-circle me-3" width="64" height="64"/>
                                <div>
                                    <p className="review-name fw-bold mb-0">Cardio Trainer</p>
                                    <p className="review-title text-muted mb-0">CEO</p>
                                </div>
                            </div>
                            <div className="review-text  text-white p-3 ">
                                <p className="mb-0">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit. Nulla, sequi quia, libero voluptatibus ducimus earum quidem minus eveniet, ex esse rem sed numquam. Error magnam in vero molestiae tempora nostrum.
                                </p>
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

export default Review