import './App.css';
import Header from "./Components/HeaderSection/header";
import Classes from "./Components/ClassesSection/classes";
import Trainer from "./Components/TrainerSection/trainer";
import Purchase from "./Components/PurchaseSection/purchase";
import Review from './Components/ReviewSection/review';
import Contact from './Components/ContactSection/contact';
import Footer from './Components/FooterSection/footer';



function App() {
  return (
    <>
      <body>
          <Header/>
          <Classes />
          <Trainer />
          <Purchase />
          <Review />
          <Contact />
          <Footer />

      </body>
    </>
  );
}

export default App


