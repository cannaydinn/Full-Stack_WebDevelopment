
const userName = prompt("Lütfen isminizi giriniz:");

if(userName){
    const showName = document.getElementById('myName'); 
    showName.textContent = userName;  
}
 else {
    alert("Herhangi bir isim girmediniz.");
}

function showTime() {
    const clockDiv = document.getElementById('myClock');
    const now = new Date(); // Anlık saat ve tarihi al
    const hours = String(now.getHours()).padStart(2, '0'); // Saat (HH)
    const minutes = String(now.getMinutes()).padStart(2, '0'); // Dakika (MM)
    const seconds = String(now.getSeconds()).padStart(2, '0'); // Saniye (SS)
    const time = `${hours}:${minutes}:${seconds}`; // HH:MM:SS formatı
    clockDiv.textContent = time; // Saati ekrana yaz
}
// Her bir saniyede bir saati güncelle
setInterval(showTime, 1000);
showTime();


