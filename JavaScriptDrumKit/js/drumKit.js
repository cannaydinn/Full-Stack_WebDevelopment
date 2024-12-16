function play(key){
    const button = document.getElementById(key);
    let audio;
    switch(key){
        case 'A':
            audio = new Audio('audio/boom.wav');
            break;
        case 'S':
            audio = new Audio('audio/clap.wav');
            break;
        case 'D':
            audio = new Audio('audio/hihat.wav');
            break;
        case 'F':
            audio = new Audio('audio/kick.wav');
            break;
        case 'G':
            audio = new Audio('audio/openhat.wav');
            break;
        case 'H':
            audio = new Audio('audio/ride.wav');
            break;
        case 'J':
            audio = new Audio('audio/snare.wav');
            break;
        case 'K':
            audio = new Audio('audio/tink.wav');
            break;
        case 'L':
            audio = new Audio('audio/tom.wav');
            break;
        default:
            console.log('Geçersiz tuş: ', key);
            return;

    }
    audio.play();
}

document.addEventListener('keydown', function(event) {
    const key = event.key.toUpperCase(); 
    play(key); 
});
