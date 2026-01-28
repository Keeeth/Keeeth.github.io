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
            height: 100%;
            margin: 0;
            padding: 0;
            overflow: hidden; 
            font-family: "Times New Roman", serif;
            background-color: #000;
            animation: globalFadeIn 1.5s ease-out forwards;
        }

        body {
            display: flex;
            flex-direction: column;
            padding: 10px;
            box-sizing: border-box;
            color: gold;
        }

        #video-bg {
            position: fixed;
            top: 0; left: 0; width: 100%; height: 100%;
            object-fit: cover;
            z-index: -1;
            filter: brightness(40%);
        }

        /* MUSIC PLAYER */
        .music-container {
            position: fixed;
            top: 10px;
            left: 50%;
            transform: translateX(-50%);
            z-index: 9999;
            width: 90%;
            max-width: 400px;
        }

        #summer {
            font-size: 2.2rem;
            font-family: fantasy;
            color: #FFD700;
            text-align: center;
            margin-top: 170px; /* Space for the music player */
            margin-bottom: 10px;
            text-shadow: 0 0 15px rgba(0,0,0,1);
        }

        .main-content {
            display: flex;
            flex-direction: row; 
            gap: 15px;
            flex: 1;
            min-height: 0; 
            align-items: center;
            justify-content: center;
            max-width: 1100px;
            margin: 0 auto;
        }

        /* THE PICTURE FRAME (RESTORED) */
        .park {
            flex: 1.2;
            height: 350px;
            position: relative;
            border: 5px solid gold; /* The Frame */
            box-shadow: 0 10px 30px rgba(0,0,0,0.8);
            border-radius: 8px;
            overflow: hidden;
        }

        /* PHOTO ANIMATION LOGIC */
        .fade-img {
            position: absolute;
            top: 0; left: 0;
            width: 100%; height: 100%;
            object-fit: cover;
            opacity: 0;
            animation: imageCycle 24s infinite;
        }

        /* Staggered animation delays (RESTORED) */
        .fade-img:nth-child(1) { animation-delay: 0s; }
        .fade-img:nth-child(2) { animation-delay: 4s; }
        .fade-img:nth-child(3) { animation-delay: 8s; }
        .fade-img:nth-child(4) { animation-delay: 12s; }
        .fade-img:nth-child(5) { animation-delay: 16s; }
        .fade-img:nth-child(6) { animation-delay: 20s; }
        
        @keyframes imageCycle {
            0% { opacity: 0; }
            2% { opacity: 1; }   /* Fade in */
            17% { opacity: 1; }  /* Stay visible */
            22% { opacity: 0; }  /* Fade out */
            100% { opacity: 0; }
        }

        /* THE TEXT BOX */
        .island {
            flex: 1;
            background: rgba(0, 0, 50, 0.5); 
            backdrop-filter: blur(15px); 
            padding: 20px;
            border: 1px solid rgba(255, 215, 0, 0.3);
            border-radius: 15px;
            max-height: 50vh;
            overflow-y: auto;
            color: #fff;
        }

        .ticket-container { text-align: center; padding: 15px 0; }

        .buy-button {
            background: linear-gradient(135deg, #FFD700, #FFA500);
            color: #000;
            padding: 15px 40px;
            font-family: fantasy;
            font-size: 1.3rem;
            text-decoration: none;
            border-radius: 50px;
            font-weight: bold;
            display: inline-block;
            transition: 0.3s;
        }

        /* MOBILE RESPONSIVENESS */
        @media (max-width: 768px) {
            .main-content { flex-direction: column; gap: 10px; }
            #summer { font-size: 1.5rem; margin-top: 160px; }
            .park { width: 95%; height: 25vh; min-height: 180px; }
            .island { max-height: 25vh; }
        }
    </style>
</head>
<body>

    <video autoplay muted loop playsinline id="video-bg">
        <source src="https://assets.mixkit.co/videos/preview/mixkit-tropical-beach-with-palm-trees-1563-large.mp4" type="video/mp4">
    </video>

    <div class="music-container">
        <iframe 
            allow="autoplay *; encrypted-media *;" frameborder="0" height="150" 
            style="width:100%;max-width:660px;overflow:hidden;background:transparent;border-radius:10px;" 
            sandbox="allow-forms allow-popups allow-same-origin allow-scripts allow-storage-access-by-user-activation allow-top-navigation-by-user-activation" 
            src="https://embed.music.apple.com/us/album/jamming/1469575763?i=1469576116">
        </iframe>
    </div>

    <h1 id="summer">United States Virgin Islands</h1> 

    <div class="main-content">
        <div class="park"> 
            <img src="https://images.pexels.com/photos/1450353/pexels-photo-1450353.jpeg?auto=compress&cs=tinysrgb&w=600" class="fade-img" alt="Beach 1">
            <img src="https://images.pexels.com/photos/1287441/pexels-photo-1287441.jpeg?auto=compress&cs=tinysrgb&w=600" class="fade-img" alt="Beach 2">
            <img src="https://images.pexels.com/photos/1174732/pexels-photo-1174732.jpeg?auto=compress&cs=tinysrgb&w=600" class="fade-img" alt="Beach 3">
            <img src="https://images.pexels.com/photos/1618606/pexels-photo-1618606.jpeg?auto=compress&cs=tinysrgb&w=600" class="fade-img" alt="Sea Turtle 4">
            <img src="https://images.pexels.com/photos/1544376/pexels-photo-1544376.jpeg?auto=compress&cs=tinysrgb&w=600" class="fade-img" alt="View 5"> 
            <img src="https://images.pexels.com/photos/3320529/pexels-photo-3320529.jpeg?auto=compress&cs=tinysrgb&w=600" class="fade-img" alt="Paradise 6">          
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
