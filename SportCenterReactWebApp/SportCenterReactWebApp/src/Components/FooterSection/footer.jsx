import "./footer.css";

function Footer() {
  return (
    <>
        <footer className="footer">
        <div className="container">
            <div className="text-md-start text-center">
                <div className="footer-logo">
                    <img src="src/assets/images/logo.png" alt="Footer Logo" className="img-fluid"/>
                </div>
                <p>
                    Lorem ipsum, dolor sit amet consectetur adipisicing elit. Tenetur impedit, accusamus recusandae sunt laudantium nihil quisquam amet vitae ducimus quod temporibus architecto qui quos iste exercitationem fugit vel id enim.
                    Iste, consectetur repudiandae eum sequi quaerat dignissimos officiis consequuntur. Voluptatem laborum laboriosam, accusamus odio sit sunt quas a necessitatibus natus, ratione illum vitae molestiae animi nisi iste earum eum id.
                </p>
            </div>
            <div className="row">
                <div className="col-6">
                    <h5>Information</h5>
                    <ul className="footer-links">
                        <li><a href="#">About Us</a></li>
                        <li><a href="#">Classes</a></li>
                        <li><a href="#">Blog</a></li>
                        <li><a href="#">Contact</a></li>
                    </ul>
                </div>
                <div className="col-6">
                    <h5>Helpful Links</h5>
                    <ul className="footer-links">
                        <li><a href="#">Services</a></li>
                        <li><a href="#">Supports</a></li>
                        <li><a href="#">Terms & Condition</a></li>
                        <li><a href="#">Privacy Policy</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </footer>
    </>
  )
}

export default Footer