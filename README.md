<!DOCTYPE html>
<html lang="en-US">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Project: Travel webpage</title>
    <style>
        /* 1. THE FADE-IN ANIMATION */
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
            /* Apply fade to the whole body */
            animation: globalFadeIn 1.5s ease-out forwards;
        }

        /* 2. VIDEO BACKGROUND */
        #video-bg {
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            object-fit: cover;
            z-index: -1;
            filter: brightness(50%); /* Darkened for higher contrast */
        }

        body {
            display: flex;
            flex-direction: column;
            padding: 15px;
            box-sizing: border-box;
        }

        #summer {
            font-size: 2.5rem;
            font-family: fantasy;
            color: #FFD700;
            text-align: center;
            margin: 10px 0;
            text-shadow: 0 0 20px rgba(0,0,0,1);
        }

        /* 3. CONTENT AREA */
        .main-content {
            display: flex;
            flex-direction: row; 
            gap: 20px;
            flex: 1;
            min-height: 0;
            align-items: center;
            justify-content: center;
            max-width: 1200px;
            margin: 0 auto;
        }

        .park {
            flex: 1.2;
            border: 5px solid gold;
            box-shadow: 0 15px 50px rgba(0,0,0,0.8);
            border-radius: 4px;
            overflow: hidden;
        }

        .park img {
            width: 100%;
            height: auto;
            max-height: 50vh;
            display: block;
        }

        /* 4. GLASSMORPHISM CONTENT BOX */
        .island {
            flex: 1;
            background: rgba(0, 0, 50, 0.4); 
            backdrop-filter: blur(15px); 
            -webkit-backdrop-filter: blur(15px);
            padding: 25px;
            border: 1px solid rgba(255, 215, 0, 0.2);
            border-radius: 20px;
            font-size: 1.1rem;
            max-height: 50vh;
            overflow-y: auto;
            color: #fff;
            box-shadow: 0 10px 30px rgba(0,0,0,0.5);
        }

        .island strong { color: gold; font-size: 1.2rem; }

        .explore {
            text-align: center;
            font-family: fantasy;
            color: gold;
            text-transform: uppercase;
            letter-spacing: 2px;
            margin-bottom: 5px;
        }

        .explore ul {
            list-style: none;
            padding: 0;
            display: flex;
            justify-content: center;
            gap: 25px;
            font-size: 0.85rem;
        }

        /* 5. CTA BUTTON */
        .ticket-container {
            text-align: center;
            padding: 20px 0;
        }

        .buy-button {
            background: linear-gradient(135deg, #FFD700, #FFA500);
            color: #000;
            padding: 18px 50px;
            font-family: fantasy;
            font-size: 1.5rem;
            text-decoration: none;
            border-radius: 60px;
            font-weight: bold;
            box-shadow: 0 0 30px rgba(255, 215, 0, 0.4);
            transition: all 0.4s cubic-bezier(0.175, 0.885, 0.32, 1.275);
            display: inline-block;
        }

        .buy-button:hover {
            transform: scale(1.1) translateY(-5px);
            background: #fff;
            box-shadow: 0 0 50px rgba(255, 215, 0, 0.8);
        }

        /* MOBILE ADJUSTMENTS */
        @media (max-width: 768px) {
            .main-content { flex-direction: column; gap: 15px; }
            .park img, .island { max-height: 25vh; }
            #summer { font-size: 1.6rem; }
            .island { padding: 15px; font-size: 0.95rem; }
            .explore ul { gap: 10px; font-size: 0.7rem; }
        }
    </style>
</head>
<body>

    <video autoplay muted loop playsinline id="video-bg">
        <source src="https://assets.mixkit.co/videos/preview/mixkit-tropical-beach-with-palm-trees-1563-large.mp4" type="video/mp4">
    </video>

    <h1 id="summer">United States Virgin Islands</h1> 

    <div class="explore"> 
        <ul>
            <li>🌴 Wildlife</li>
            <li>🥾 Terrain</li>
            <li>⚓ Enclaves</li>
        </ul> 
    </div>

    <div class="main-content">
        <div class="park"> 
            <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/Virgin_Islands_National_Park.jpg/320px-Virgin_Islands_National_Park.jpg" alt="Virgin Islands">
        </div>

        <div class="island">   
            <p><strong>St Thomas</strong><br>A lively island with a sophisticated atmosphere. Perfect for sea turtles and lobsters calling this paradise home.</p>
            <p><strong>Carvel Rock</strong><br>A must for divers on St. Johns. Keep an eye out for sting rays, nurse sharks, and octopus passing by.</p>
            <p><strong>Travel Info</strong><br>Currency: US Dollar. Major credit cards are widely accepted. ATMs are available at the Cruise Ship Dock.</p>
        </div>
    </div>

    <div class="ticket-container">
        <a href="#" class="buy-button">🎟️ BUY TICKETS NOW</a>
    </div>

</body>
</html>
