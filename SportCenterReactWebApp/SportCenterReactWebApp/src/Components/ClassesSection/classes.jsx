import { useState, useEffect } from "react";
import "./classes.css";

function Classes() {
    const [height, setHeight] = useState(0); // Boy (cm), başlangıç değeri 0
    const [weight, setWeight] = useState(0); // Kilo (kg), başlangıç değeri 0
    const [arrowPosition, setArrowPosition] = useState(0); // Ok pozisyonu
    const scaleWidth = 350; // Ölçek genişliği (CSS ile uyumlu)

    // BMI hesaplama ve ok pozisyonu ayarlama
    useEffect(() => {
        if (height === 0 || weight === 0) {
        setArrowPosition(0); // Eğer boy veya kilo sıfırsa ok pozisyonunu sıfırla
        return;
        }

        const heightInMeters = height / 100;
        const bmi = weight / (heightInMeters * heightInMeters);

        let position = 0;
        if (bmi < 18.5) {
        position = scaleWidth * 0.1; // Zayıf
        } else if (bmi >= 18.5 && bmi <= 24.9) {
        position = scaleWidth * 0.3; // Normal
        } else if (bmi >= 25 && bmi <= 29.9) {
        position = scaleWidth * 0.5; // Fazla kilolu
        } else if (bmi >= 30 && bmi <= 34.9) {
        position = scaleWidth * 0.7; // Obez
        } else {
        position = scaleWidth * 0.9; // Aşırı obez
        }

        setArrowPosition(position); // Ok pozisyonunu güncelle
    }, [height, weight, scaleWidth]);

    // Butonların tıklama olaylarını yönet
    useEffect(() => {
        const sectionWhiteButtons = document.querySelectorAll(".section-white .btn");

        sectionWhiteButtons.forEach((button) => {
        button.addEventListener("click", function () {
            sectionWhiteButtons.forEach((btn) => {
            btn.classList.remove("button-active", "blur");
            });
            this.classList.add("button-active", "blur");
        });
        });

        return () => {
        sectionWhiteButtons.forEach((button) => {
            button.removeEventListener("click", () => {});
        });
        };
    }, []);

    
    
  return (
    <>  
        <section className="section section-white" id="classes">
            <div className="trapezoid-wrapper">
                <div className="trapezoid"></div>
            </div>
            <div className="container">
                <div className="section-title">
                    <h3>OUR CLASSES</h3>
                    <div className="orange-line"></div>
                    <div className="text">
                        <p>Lorem Ipsum is not simply random text. It has roots in a piece of classical at Hampden-Sydney Collage</p>
                    </div>
                </div>
                <div className="section-content" id="ecosystem">
                    <div className="buttons">
                        <div className="row">
                            <div className="box">
                                <button data-bs-toggle="collapse" data-bs-target=".yoga" className="btn btn-yoga active" id="yoga">Yoga</button>
                            </div>
                            <div className="box">
                                <button data-bs-toggle="collapse" data-bs-target=".group" className="btn btn-group" id="group">Group</button>
                            </div>
                            <div className="box">
                                <button data-bs-toggle="collapse" data-bs-target=".solo" className="btn btn-solo" id="solo">Solo</button>
                            </div>
                            <div className="box">
                                <button data-bs-toggle="collapse" data-bs-target=".stretching" className="btn btn-stretching" id="stretching">Stretching</button>
                            </div>
                        </div>
                    </div>
                    <div className="row">
                        <div className="content classes">
                            <div className="col-4">
                                <div className="collapse show yoga" data-bs-parent="#ecosystem">
                                    <h4>Why are your Yoga?</h4>
                                    <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Ducimus, atque labore, dolore eligendi ipsa deleniti excepturi sint voluptatem facilis, nobis tenetur ratione animi. Exercitationem voluptate maxime, eveniet ducimus placeat nisi!</p>
                                    <h4>When Comes Yoga Your Time.</h4>
                                    <p>Saturday-Sanday: 8:00am - 10:00am</p>
                                    <p>Monday-Tuesday: 10:00am - 12:00pm</p>
                                    <p>Wednesday-Friday: 3:00pm - 6:00pm</p>
                                </div>
                                <div className="collapse group" data-bs-parent="#ecosystem">
                                    <h4>Why are your Yoga?</h4>
                                    <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Ducimus, atque labore, dolore eligendi ipsa deleniti excepturi sint voluptatem facilis, nobis tenetur ratione animi. Exercitationem voluptate maxime, eveniet ducimus placeat nisi!</p>
                                    <h4>When Comes Yoga Your Time.</h4>
                                    <p>Saturday-Sanday: 8:00am - 10:00am</p>
                                    <p>Monday-Tuesday: 10:00am - 12:00pm</p>
                                    <p>Wednesday-Friday: 3:00pm - 6:00pm</p>
                                </div>
                                <div className="collapse solo" data-bs-parent="#ecosystem">
                                    <h4>Why are your Yoga?</h4>
                                    <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Ducimus, atque labore, dolore eligendi ipsa deleniti excepturi sint voluptatem facilis, nobis tenetur ratione animi. Exercitationem voluptate maxime, eveniet ducimus placeat nisi!</p>
                                    <h4>When Comes Yoga Your Time.</h4>
                                    <p>Saturday-Sanday: 8:00am - 10:00am</p>
                                    <p>Monday-Tuesday: 10:00am - 12:00pm</p>
                                    <p>Wednesday-Friday: 3:00pm - 6:00pm</p>
                                </div>
                                <div className="collapse stretching" data-bs-parent="#ecosystem">
                                    <h4>Why are your Yoga?</h4>
                                    <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Ducimus, atque labore, dolore eligendi ipsa deleniti excepturi sint voluptatem facilis, nobis tenetur ratione animi. Exercitationem voluptate maxime, eveniet ducimus placeat nisi!</p>
                                    <h4>When Comes Yoga Your Time.</h4>
                                    <p>Saturday-Sanday: 8:00am - 10:00am</p>
                                    <p>Monday-Tuesday: 10:00am - 12:00pm</p>
                                    <p>Wednesday-Friday: 3:00pm - 6:00pm</p>
                                </div>
                            </div>
                            <div className="col-4">
                                <img src="src/assets/images/yoga.jpg" alt="" className="yoga collapse show img-fluid"/>
                                <img src="src/assets/images/group.webp" alt="" className="group collapse img-fluid"/>
                                <img src="src/assets/images/solo.jpg" alt="" className="solo collapse img-fluid"/>
                                <img src="src/assets/images/stret.webp" alt="" className="stretching collapse img-fluid"/>
                            </div>
                        </div>
                    </div>
                    <div className="row">
                        <div className="content calculator">
                            <div className="col-4">
                                <h3>BMI Calculator</h3>
                                <p className="mt-4 mb-4">
                                    Contrary to popular belief, Lorem lpsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old
                                </p>
                                <p className="mb-4">
                                    Contrary to popular belief, Lorem lpsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old
                                </p>
                                <div className="bmi">
                                    <input 
                                        type="number" 
                                        placeholder="Your Height" 
                                        id="height" 
                                        value={height}
                                        name="height" 
                                        onChange={(e) => setHeight(Number(e.target.value))}
                                    />
                                    <label>cm</label>
                                </div>
                                <div className="bmi">
                                    <input 
                                        type="number" 
                                        placeholder="Your Weight" 
                                        id="weight" 
                                        value={weight}
                                        name="weight"
                                        onChange={(e) => setWeight(Number(e.target.value))}
                                        /> 
                                    <label>kg</label>
                                </div>
                            </div>
                            <div className="col-4">
                                <div className="bmi-container">
                                    <p className="text-center">Your BMI</p>
                                    <img src="src/assets/images/bmi-index.jpg" alt="BMI Scale" className="img-fluid"/>
                                    <div className="bmi-scale">
                                        <div className="bmi-arrow" id="bmiArrow" style={{left: `${arrowPosition}px`,}}></div>
                                    </div>
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

export default Classes