<!DOCTYPE html>
<html lang="en-US">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Travel Project - US Virgin Islands</title>
    <style>
        /* Fade-in entrance */
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
            overflow-y: auto; /* Enables scrolling for the button */
        }

        body {
            display: flex;
            flex-direction: column;
            min-height: 100vh;
            color: gold;
        }

        #video-bg {
            position: fixed;
            top: 0; left: 0; width: 100%; height: 100%;
            object-fit: cover;
            z-index: -1;
            filter: brightness(35%);
        }

        /* COMPACT MUSIC PLAYER */
        .music-container {
            position: fixed;
            top: 10px;
            left: 50%;
            transform: translateX(-50%) scale(0.65);
            z-index: 1000;
            width: 100%;
            max-width: 400px;
            transform-origin: top;
        }

        header {
            text-align: center;
            margin-top: 110px; /* Space below music player */
            padding: 0 10px;
        }

        #summer {
            font-size: 2.2rem;
            font-family: fantasy;
            color: #FFD700;
            margin: 0;
            text-shadow: 0 0 15px rgba(0,0,0,1);
        }

        .main-content {
            display: flex;
            flex-direction: row; 
            gap: 20px;
            align-items: center;
            justify-content: center;
            max-width: 1100px;
            margin: 20px auto;
            padding: 0 20px;
        }

        /* PHOTO FRAME */
        .park {
            flex: 1.2;
            height: 350px;
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

        /* Image timing logic */
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

        /* RESTORED TEXT BOX (The missing div style) */
        .island {
            flex: 1;
            background: rgba(15, 15, 35, 0.75); /* Darker "glass" for readability */
            backdrop-filter: blur(12px); 
            padding: 25px;
            border: 1px solid rgba(255, 215, 0, 0.3);
            border-radius: 15px;
            color: #fff;
            box-shadow: 0 8px 32px 0 rgba(0, 0, 0, 0.5);
        }

        .island p { margin-bottom: 15px; line-height: 1.4; }

        .ticket-container { 
            text-align: center; 
            padding: 30px 0 80px 0; /* Bottom padding for mobile browser bars */
        }

        .buy-button {
            background: linear-gradient(135deg, #FFD700, #FFA500);
            color: #000;
            padding: 15px 45px;
            font-family: fantasy;
            font-size: 1.4rem;
            text-decoration: none;
            border-radius: 50px;
            font-weight: bold;
            display: inline-block;
            transition: 0.3s;
            box-shadow: 0 5px 15px rgba(255, 215, 0, 0.3);
        }

        .buy-button:hover { transform: scale(1.05); }

        /* MOBILE FIXES */
        @media (max-width: 768px) {
            .main-content { flex-direction: column; margin-top: 10px; }
            #summer { font-size: 1.6rem; }
            header { margin-top: 90px; }
            .park { width: 100%; height: 240px; }
            .island { width: 100%; box-sizing: border-box; }
        }
    </style>
</head>
<body>

    <video autoplay muted loop playsinline id="video-bg">
        <source src="https://assets.mixkit.co/videos/preview/mixkit-tropical-beach-with-palm-trees-1563-large.mp4" type="video/mp4">
    </video>

    <div class="music-container">
        <iframe allow="autoplay *; encrypted-media *;" frameborder="0" height="150" 
            style="width:100%;overflow:hidden;background:transparent;border-radius:10px;" 
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
        <a href="#" class="buy-button">🎟️ BUY TICKETS NOW</a>
    </div>

</body>
</html>
