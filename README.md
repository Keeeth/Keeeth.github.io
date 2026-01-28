<!DOCTYPE html>
<html lang="en-US">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Travel Project - US Virgin Islands</title>
    <style>
        /* ... Keep all your existing CSS here ... */

        /* ADD THESE TWO UPDATED RULES IN YOUR STYLE TAG */
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
            margin-top: 180px; /* Added margin so title sits below the music player */
            text-shadow: 0 0 15px rgba(0,0,0,1);
        }

        /* Your existing fade-img and @keyframes logic... */
        @keyframes imageCycle {
            0% { opacity: 0; }
            5% { opacity: 1; }
            16% { opacity: 1; }
            21% { opacity: 0; }
            100% { opacity: 0; }
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
