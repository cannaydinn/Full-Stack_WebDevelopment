// Toast bildirimini göstermek için bir yardımcı fonksiyon
function showToast(type) {
    const toast = document.querySelector(`.toast.${type}`);
    $(toast).toast("show");
  }
  
  // Yeni bir liste elemanı ekleme
  function newElement() {
    const taskInput = document.getElementById("task");
    const taskValue = taskInput.value.trim(); // Boşlukları temizle
  
    if (taskValue === "") {
      // Eğer giriş boşsa hata mesajı göster
      showToast("error");
      return;
    }
  
    // Yeni liste elemanı oluştur
    const li = document.createElement("li");
    li.textContent = taskValue;
  
    // Silme düğmesini ekle
    const closeButton = document.createElement("span");
    closeButton.className = "close";
    closeButton.textContent = "\u00D7"; // Unicode çarpı işareti
    closeButton.onclick = function () {
      this.parentElement.remove();
    };
  
    li.appendChild(closeButton);
  
    // Listeye ekle
    const list = document.getElementById("list");
    list.appendChild(li);
  
    // Başarı mesajını göster
    showToast("success");
  
    // Giriş alanını temizle
    taskInput.value = "";
  }
  
  // Liste elemanını işaretlemek için event listener ekleme
  document.getElementById("list").addEventListener("click", function (e) {
    if (e.target.tagName === "LI") {
      e.target.classList.toggle("checked");
    }
  });