import { useState } from "react";
import "./App.css";

function App() {
  const [todos, setTodos] = useState([]); // Yapılacaklar listesi
  const [inputValue, setInputValue] = useState(""); // Input değeri
  const [filter, setFilter] = useState("all"); // Filtreleme durumu

  const handleSubmit = (e) => {
    e.preventDefault();
    if (inputValue.trim() === "") return;

    setTodos([...todos, { id: Date.now(), text: inputValue, completed: false }]);
    setInputValue("");
  };

  const deleteTodo = (id) => {
    setTodos(todos.filter((todo) => todo.id !== id));
  };

  // Checkbox işaretlendiğinde tamamlanma durumunu değiştir
  const toggleComplete = (id) => {
    setTodos(
      todos.map((todo) =>
        todo.id === id ? { ...todo, completed: !todo.completed } : todo
      )
    );
  };

  // Seçili filtreye göre Todo'ları göster
  const filteredTodos = todos.filter((todo) => {
    if (filter === "active") return !todo.completed;
    if (filter === "completed") return todo.completed;
    return true;
  });

  return (
    <>
      <section className="todoapp">
        <header className="header">
          <h1>todos</h1>
          <form onSubmit={handleSubmit}>
            <input
              className="new-todo"
              placeholder="What needs to be done?"
              autoFocus
              value={inputValue}
              onChange={(e) => setInputValue(e.target.value)}
            />
          </form>
        </header>

        <section className="main">
          <ul className="todo-list">
            {filteredTodos.map((todo) => (
              <li key={todo.id} className={todo.completed ? "completed" : ""}>
                <div className="view">
                  <input
                    className="toggle"
                    type="checkbox"
                    checked={todo.completed}
                    onChange={() => toggleComplete(todo.id)}
                  />
                  <label>{todo.text}</label>
                  <button className="destroy" onClick={() => deleteTodo(todo.id)}></button>
                </div>
              </li>
            ))}
          </ul>
        </section>

        <footer className="footer">
          <span className="todo-count">
            <strong>{todos.filter((todo) => !todo.completed).length}</strong> items left
          </span>

          <ul className="filters">
            <li>
              <a href="#/" className={filter === "all" ? "selected" : ""} onClick={() => setFilter("all")}>
                All
              </a>
            </li>
            <li>
              <a href="#/" className={filter === "active" ? "selected" : ""} onClick={() => setFilter("active")}>
                Active
              </a>
            </li>
            <li>
              <a href="#/" className={filter === "completed" ? "selected" : ""} onClick={() => setFilter("completed")}>
                Completed
              </a>
            </li>
          </ul>
        </footer>
      </section>
    </>
  );
}

export default App;