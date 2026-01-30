<!DOCTYPE html>
<html lang="en-US">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Travel Project - US Virgin Islands</title>
    <style>
        /* Global Entrance Animation */
        @keyframes globalFadeIn {
            from { opacity: 0; transform: translateY(10px); }
            to { opacity: 1; transform: translateY(0); }
        }

        html, body {
            margin: 0;
            padding: 0;
            background-color: #000;
            font-family: "Times New Roman", serif;
            animation: globalFadeIn 1.5s ease-out forwards;
            overflow-x: hidden;
            height: 100%;
        }

        body {
            display: flex;
            flex-direction: column;
            color: gold;
        }

        #video-bg {
            position: fixed;
            top: 0; left: 0; width: 100%; height: 100%;
            object-fit: cover;
            z-index: -1;
            filter: brightness(35%);
        }

        /* MUSIC PLAYER - Positioned to cover top-left area */
        .music-container {
            position: fixed;
            top: 0;
            left: 0;
            z-index: 1000;
            width: 100%;
            max-width: 400px;
        }

        header {
            text-align: center;
            margin-top: 160px; /* Space for the music player */
            padding: 10px;
        }

        #summer {
            font-size: 3rem;
            font-family: fantasy;
            color: #FFD700;
            margin: 0;
            text-shadow: 0 0 15px rgba(0,0,0,1);
        }

        /* MAIN LAYOUT - Side-by-Side with Equal Height */
        .main-content {
            display: flex;
            flex-direction: row; 
            gap: 20px;
            align-items: stretch; /* This makes both boxes the same height */
            justify-content: center;
            max-width: 1100px;
            margin: 20px auto;
            padding: 0 20px;
        }

        /* THE PHOTO BOX */
        .park {
            flex: 1.2; /* Slightly wider than text box */
            height: 400px; 
            position: relative;
            border: 4px solid gold;
            border-radius: 12px;
            overflow: hidden;
            box-shadow: 0 10px 30px rgba(0,0,0,0.8);
        }

        .fade-img {
            position: absolute;
            top: 0; left: 0;
            width: 100%; height: 100%;
            object-fit: cover;
            opacity: 0;
            animation: imageCycle 24s infinite;
        }

        /* Image Delays */
        .fade-img:nth-child(1) { animation-delay: 0s; }
        .fade-img:nth-child(2) { animation-delay: 4s; }
        .fade-img:nth-child(3) { animation-delay: 8s; }
        .fade-img:nth-child(4) { animation-delay: 12s; }
        .fade-img:nth-child(5) { animation-delay: 16s; }
        .fade-img:nth-child(6) { animation-delay: 20s; }

        @keyframes imageCycle {
            0% { opacity: 0; }
            5% { opacity: 1; }
            16% { opacity: 1; }
            21% { opacity: 0; }
            100% { opacity: 0; }
        }

        /* THE SCROLLING TEXT BOX */
        .island {
            flex: 1;
            background: rgba(15, 15, 35, 0.85); 
            backdrop-filter: blur(15px); 
            padding: 20px;
            border: 1px solid rgba(255, 215, 0, 0.3);
            border-radius: 15px;
            color: #fff;
            overflow-y: auto; 
        }

        .island p { margin-top: 0; font-size: 1.1rem; }

        /* Scrollbar Styling */
        .island::-webkit-scrollbar { width: 6px; }
        .island::-webkit-scrollbar-thumb { background: gold; border-radius: 10px; }

        .ticket-container { 
            text-align: center; 
            padding: 10px 0 40px 0; 
        }

        .buy-button {
            background: linear-gradient(135deg, #FFD700, #FFA500);
            color: #000;
            padding: 12px 35px;
            font-family: fantasy;
            font-size: 1.2rem;
            text-decoration: none;
            border-radius: 50px;
            font-weight: bold;
            cursor: pointer;
            border: none;
            transition: transform 0.2s;
        }
        .buy-button:active { transform: scale(0.95); }

        /* TOAST MESSAGE */
        #toast {
            visibility: hidden;
            min-width: 250px;
            background-color: #28a745;
            color: #fff;
            text-align: center;
            border-radius: 50px;
            padding: 16px;
            position: fixed;
            z-index: 2000;
            left: 50%;
            bottom: 30px;
            transform: translateX(-50%);
        }
        #toast.show { visibility: visible; animation: fadein 0.5s, fadeout 0.5s 2.5s; }
        @keyframes fadein { from {bottom: 0; opacity: 0;} to {bottom: 30px; opacity: 1;} }
        @keyframes fadeout { from {bottom: 30px; opacity: 1;} to {bottom: 0; opacity: 0;} }

        /* MOBILE RESPONSIVE RULES */
        @media (max-width: 768px) {
            header { margin-top: 155px; padding: 5px; }
            
            #summer { font-size: 1.6rem; } /* Smaller font for mobile */

            .main-content { 
                flex-direction: column; 
                align-items: center;
                gap: 10px;
                margin: 10px auto;
            }

            .park { 
                width: 100%; 
                height: 180px; /* Reduced height to save screen space */
                min-height: 180px; 
            }

            .island { 
                width: 100%; 
                height: auto; 
                max-height: 180px; /* Limit height to prevent scrolling off screen */
                padding: 15px;
                font-size: 0.9rem;
            }

            .ticket-container { padding: 10px 0 20px 0; }
            
            .buy-button { font-size: 1rem; padding: 10px 25px; }
        }
    </style>
</head>
<body>

    <video autoplay muted loop playsinline id="video-bg">
        <source src="https://assets.mixkit.co/videos/preview/mixkit-tropical-beach-with-palm-trees-1563-large.mp4" type="video/mp4">
    </video>

    <div class="music-container">
        <iframe allow="autoplay *; encrypted-media *;" frameborder="0" height="150" 
            style="width:100%;max-width:400px;overflow:hidden;background:transparent;" 
            sandbox="allow-forms allow-popups allow-same-origin allow-scripts allow-storage-access-by-user-activation allow-top-navigation-by-user-activation" 
            src="https://embed.music.apple.com/us/album/jamming/1469575763?i=1469576116">
        </iframe>
    </div>

    <header>
        <h1 id="summer">United States Virgin Islands</h1> 
    </header>

    <div class="main-content">
        <div class="park"> 
            <img src="https://images.pexels.com/photos/1450353/pexels-photo-1450353.jpeg?auto=compress&cs=tinysrgb&w=600" class="fade-img">
            <img src="https://images.pexels.com/photos/1287441/pexels-photo-1287441.jpeg?auto=compress&cs=tinysrgb&w=600" class="fade-img">
            <img src="https://images.pexels.com/photos/1174732/pexels-photo-1174732.jpeg?auto=compress&cs=tinysrgb&w=600" class="fade-img">
            <img src="https://images.pexels.com/photos/1618606/pexels-photo-1618606.jpeg?auto=compress&cs=tinysrgb&w=600" class="fade-img">
            <img src="https://images.pexels.com/photos/1544376/pexels-photo-1544376.jpeg?auto=compress&cs=tinysrgb&w=600" class="fade-img"> 
            <img src="https://images.pexels.com/photos/3320529/pexels-photo-3320529.jpeg?auto=compress&cs=tinysrgb&w=600" class="fade-img">          
        </div>        
        
        <div class="island">   
            <p><strong>St Thomas</strong><br>A lively island with a sophisticated atmosphere. Perfect for sea turtles and lobsters calling this paradise home.</p>
            <p><strong>Carvel Rock</strong><br>A must for divers on St. Johns. Keep an eye out for sting rays and octopus passing by.</p>
            <p><strong>Travel Info</strong><br>Currency: US Dollar. Major credit cards are widely accepted.</p>
        </div>
    </div>

    <div class="ticket-container">
        <button class="buy-button" onclick="showSuccess()">🎟️ BUY TICKETS NOW</button>
    </div>

    <div id="toast">✅ Ticket Reserved! See you in Paradise!</div>

    <script>
        function showSuccess() {
            var x = document.getElementById("toast");
            x.className = "show";
            setTimeout(function(){ x.className = x.className.replace("show", ""); }, 3000);
        }
    const adjustLayout = () => {
    const player = document.querySelector('.music-container');
    const header = document.querySelector('header');
    
    if (player && header) {
        // OffsetHeight gets the exact pixel height including padding/borders
        const height = player.offsetHeight;
        header.style.marginTop = `${height - 40}px`; // The "Lift" happens here
    }
};

// Modern way to handle multiple events
['load', 'resize'].forEach(evt => window.addEventListener(evt, adjustLayout));


        
    </script>

</body>
</html>
