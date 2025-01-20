
import "./Header.css";

function Header({money}) {
  return (
    <>
      <div className="container mx-auto w-screen bg-white flex flex-col py-16 items-center mt-10 ">
        <img src="./public/images/steve-jobs.jpg" className="rounded-full w-32 h-32" alt="Steve Jobs Image" />
        <p className="font-bold text-3xl mt-5">Spend Steve Jobs Money</p>
      </div>
      <div className="container mx-auto money w-screen sticky top-0 text-center mt-2 py-8">
        <p className="text-white text-4xl text-bold">${money.toLocaleString("en-US")}</p>
      </div>
    </>
  );
}

export default Header