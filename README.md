<!DOCTYPE html>
<html lang="en-US">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Project: Travel webpage</title>
    <style>
        /* 1. THE FADE-IN ANIMATION DEFINITION */
        @keyframes globalFadeIn {
            from { 
                opacity: 0; 
                transform: translateY(10px); 
            }
            to { 
                opacity: 1; 
                transform: translateY(0); 
            }
        }

        html, body {
            height: 100%;
            margin: 0;
            padding: 0;
            overflow: hidden; /* Prevents global scrolling */
            font-family: "Times New Roman", serif;
            background-color: #000;
            /* Applies the fade-in to the entire page content */
            animation: globalFadeIn 1.5s ease-out forwards;
        }

        /* 2. VIDEO BACKGROUND LAYER */
        #video-bg {
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            object-fit: cover;
            z-index: -1;
            filter: brightness(50%); /* Darkened so text is easy to read */
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
            flex: 0 0 auto;
        }

        /* 3. CONTENT AREA (Flexbox Layout) */
        .main-content {
            display: flex;
            flex-direction: row; 
            gap: 20px;
            flex: 1;
            min-height: 0; /* Important for flex child scrolling */
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
            max-height: 50vh; /* Keeps image from pushing other items off screen */
            display: block;
        }

        /* 4. GLASSMORPHISM TEXT BOX */
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
            overflow-y: auto; /* Only the text box scrolls if needed */
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
            flex: 0 0 auto;
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
            flex: 0 0 auto;
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
    /* 1. Stack content vertically */
    .main-content { 
        flex-direction: column; 
        gap: 10px; 
    }
    
    /* 2. Shrink image and text box to save vertical space */
    .park img, .island { 
        max-height: 20vh; /* Reduced from 25vh to ensure button fits */
    }
    
    /* 3. Reduce font sizes for mobile headers */
    #summer { font-size: 1.5rem; margin: 5px 0; }
    .island { padding: 12px; font-size: 0.85rem; }
    
    /* 4. Shrink the button slightly for mobile */
    .buy-button {
        padding: 12px 30px;
        font-size: 1.1rem;
    }

    /* 5. Ensure the container doesn't add too much padding */
    .ticket-container {
        padding: 5px 0;
    }
}
/* Container for the sliding images */
.park {
    position: relative;
    flex: 1.2;
    border: 5px solid gold;
    box-shadow: 0 15px 50px rgba(0,0,0,0.8);
    border-radius: 4px;
    overflow: hidden;
    height: 300px; /* Fixed height to prevent layout shifting */
}

.fade-img {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    object-fit: cover;
    opacity: 0;
    animation: imageFade 12s infinite;
}

/* Stagger the start time for each image */
.fade-img:nth-child(1) { animation-delay: 0s; }
.fade-img:nth-child(2) { animation-delay: 4s; }
.fade-img:nth-child(3) { animation-delay: 8s; }

@keyframes imageFade {
    0% { opacity: 0; }
    10% { opacity: 1; }
    33% { opacity: 1; }
    43% { opacity: 0; }
    100% { opacity: 0; }
}

/* Ensure mobile height is maintained so the button stays visible */
@media (max-width: 768px) {
    .park {
        height: 20vh;
        min-height: 150px;
    }
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
        <div class="park"> <div class="park"> 
    <img src="./Keeeth_files/Virgin_Islands_National_Park.jpg" alt="Virgin Islands 1" class="fade-img">
    <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/b/b3/Trunk_Bay_USVI.jpg/640px-Trunk_Bay_USVI.jpg" alt="Virgin Islands 2" class="fade-img">
    <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Maho_Bay_St_John.jpg/640px-Maho_Bay_St_John.jpg" alt="Virgin Islands 3" class="fade-img">
</div>
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
