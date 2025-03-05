import { useState } from "react";
import "./App.css";

function App() {
  const [notes, setNotes] = useState([]);
  const [noteText, setNoteText] = useState("");
  const [selectedColor, setSelectedColor] = useState("bg-white");
  const [searchText, setSearchText] = useState(""); // Arama için state

  const handleInputChange = (e) => {
    setNoteText(e.target.value);
  };

  const handleAddNote = () => {
    if (noteText.trim()) {
      setNotes([...notes, { text: noteText, color: selectedColor }]);
      setNoteText("");
    }
  };

  const handleColorChange = (color) => {
    setSelectedColor(color);
  };

  const handleSearchChange = (e) => {
    setSearchText(e.target.value);
  };

  const filteredNotes = notes.filter((note) =>
    note.text.toLowerCase().includes(searchText.toLowerCase())
  );

  return (
    <div className="flex flex-col items-center">
      <h1>NotesApp</h1>

      <div className=" w-18 mt-4 w-1/2 ">
        <input
          type="text"
          className="p-2 bg-white rounded-full border-gray-300 border mb-4"
          placeholder="Search..."
          value={searchText}
          onChange={handleSearchChange}
        />
      </div>

      <div className="relative w-1/2 h-48 bg-gray-300 mt-4">
        <textarea
          className="w-full h-full p-6 bg-white border border-gray-300 shadow-md resize-none"
          placeholder="Type your note here..."
          value={noteText}
          onChange={handleInputChange}
        ></textarea>
        <button
          className="absolute bottom-2 right-2 bg-gray-400 w-24 h-12 rounded-full"
          onClick={handleAddNote}
        >
          Add
        </button>
        <div className="absolute bottom-2 left-2 mt-2 flex gap-2">
          {[
            "bg-fuchsia-400",
            "bg-yellow-200",
            "bg-cyan-200",
            "bg-green-300",
            "bg-rose-200",
          ].map((color) => (
            <button
              key={color}
              className={` w-10 h-10 ${color} rounded-full`}
              onClick={() => handleColorChange(color)}
            ></button>
          ))}
        </div>
      </div>

      {/* Filtrelenmiş Notlar Listesi */}
      <ul className="flex justify-center gap-3 flex-wrap mt-4">
        {filteredNotes.map((note, index) => (
          <li
            key={index}
            className={`mt-2 p-2 rounded w-32 h-auto break-words ${note.color}`}
          >
            {note.text}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;