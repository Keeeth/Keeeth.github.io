<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Project: Travel webpage</title>
    <style>
        body {
            background-color: blue;
            color: gold;
            font-family: "Times New Roman", serif;
            margin: 0;
            padding: 20px;
            overflow-x: hidden; /* Prevents side-scrolling during animations */
        }

        #summer {
            font-size: 2.5rem;
            font-family: fantasy;
            color: yellow;
            text-align: center;
            animation: fadeIN 5s infinite alternate;
        }

        .explore {
            font-family: fantasy;
            font-size: 1.5rem;
            margin-bottom: 20px;
            animation: slidein 3s infinite alternate;
        }

        /* Responsive Image Container */
        .park {
            max-width: 800px;
            margin: 20px auto;
            border: 15px ridge gold;
            line-height: 0; /* Removes gap under image */
        }

        .park img {
            width: 100%;
            height: auto;
            display: block;
        }

        /* Scrollable Content Box */
        .island {
            background-color: rgba(0, 0, 139, 0.8); /* Semi-transparent blue */
            color: gold;
            font-size: 1.2rem;
            padding: 20px;
            border: 8px ridge gold;
            max-width: 800px;
            margin: 20px auto;
            height: 300px;
            overflow-y: scroll;
        }

        /* Animations */
        @keyframes slidein {
            from { transform: translateX(0%); }
            to { transform: translateX(10%); }
        }

        @keyframes fadeIN {
            from { opacity: 0.5; }
            to { opacity: 1; }
        }

        /* Mobile Adjustments */
        @media (max-width: 600px) {
            #summer { font-size: 1.8rem; }
            .explore { font-size: 1.1rem; }
            .park { border-width: 8px; }
        }

<style>
    /* ... keep all your existing styles here ... */

    /* ADD THIS AT THE BOTTOM OF YOUR STYLE TAG */
    .ticket-container {
        display: flex;
        justify-content: center;
        padding: 30px 0;
        background-color: blue;
    }

    .buy-button {
        background-color: gold;
        color: blue;
        padding: 15px 40px;
        font-family: fantasy;
        font-size: 22px;
        text-decoration: none;
        border: 4px solid yellow;
        border-radius: 50px;
        font-weight: bold;
        transition: transform 0.3s;
        box-shadow: 0px 4px 15px rgba(0,0,0,0.5);
    }

    .buy-button:hover {
        background-color: white;
        transform: scale(1.1);
    }

    @media (max-width: 600px) {
        .ticket-container {
            position: fixed;
            bottom: 0;
            left: 0;
            width: 100%;
            padding: 15px 0;
            z-index: 999;
            background-color: rgba(0, 0, 255, 0.9);
            border-top: 2px solid gold;
        }
        .buy-button {
            width: 80%;
            text-align: center;
        }
    }
</style>





        
    </style>
</head>

<body>

    <h1 id="summer">United States Virgin Islands</h1> 

    <div class="explore"> 
        <ul>
            <li>Explore the wildlife</li>
            <li>Hike the terrain</li>
            <li>Find the hidden enclaves</li>
        </ul> 
    </div>

    <div class="park"> 
        <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/Virgin_Islands_National_Park.jpg/320px-Virgin_Islands_National_Park.jpg" alt="Virgin Islands">
    </div>

    <div class="island">   
        <p><strong>St Thomas</strong> is a lively island boasting an impressive reef edge.</p>
        <p>The island offers the natural beauty of the islands with a sophisticated and cosmopolitan atmosphere. The perfect place for sea turtles and lobsters to call home.</p>
        <p><strong>Carvel Rock</strong> is a must for divers to explore on St. Johns. Often referred to as a drift dive, keep an eye out for sting rays, nurse sharks, and octopus passing by you.</p>
        <p>The diversity of the US Virgin Islands means that vacationers and divers alike will find a vacation of their dreams.</p>
        <p>The currency is the US Dollar. Major credit cards are accepted in almost all establishments. Ask before you order food. ATM machines are located in banks and commercial locations.</p>
    </div>
</div>

    <div class="ticket-container">
        <a href="#" class="buy-button">🎟️ BUY TICKETS NOW</a>
    </div>

</body>
</html>

</body>
</html>
