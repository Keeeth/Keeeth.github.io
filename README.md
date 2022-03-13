<!DOCTYPE html>
<html>
    <head>
	    
        <meta charset="utf-8">
        <title>Project: Travel webpage</title>
		  <h1  id = "summer">United States Virgin Islands</h1> 
       <div class="explore"> <ul>
            <li >Explore the wildlife</li>
            <li>Hike the terrain</li>
            <li>Find the hidden enclaves</li>
        </ul> </div>
          <div class = "park"> <img src ="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/Virgin_Islands_National_Park.jpg/320px-Virgin_Islands_National_Park.jpg" width = "100%" height = "100%"  ></div>
	      
        
		<style>
		#summer{
			font-size:30px;
			font-family:fantasy;
			color:yellow;
			top:350px;
			margin-left:10%;
			z-index:1;
			}
			.explore{
			
				color:gold;
				font-family:fantasy;
				font-size:24px;
				font-style:bold;
				margin-left:10%;
				top:600px;
				z-index:1;
			}
			.park{
				display:flex;
				justify-content:center;
				position:absolute;
				width:85vh;
				height:70vh;
				border:25px ridge gold;
				left:10%;
			}
	       .island {	
	
			  position:absolute; 
			  margin-right:20px;
                	  top:145%;
			  height:65%;
			  background-color:blue;
            	          color:gold;
            	          font-family: "Times New Roman";
                          font-style:italic;
                          font-size:33px;
			  padding:30px;			  
                          border: 6px ridge blue;
                          margin-right:10px;
                          margin-left:10px;
			  overflow-y:scroll;
             
			 
            			
			 }
                   body{
			background-color:blue;		
					
			}
			li {
                           animation-duration: 3s;
                           animation-name: slidein;
                           animation-iteration-count: infinite;
                           animation-direction: alternate;
                           }
			   @keyframes slidein {
                           from {
                           margin-left: 50%;
                           width: 300%;
                        }

                        to {
                            margin-left: 0%;
                            width: 100%;
                         }
                      }
			
			h1 {
                           animation-duration: 10s;
                           animation-name: fadeIN;
                           animation-iteration-count: infinite;
                           animation-direction: alternate;
                           }
			   @keyframes fadeIN {
                           from {
                           margin-left: 50%;
                           width: 300%;
                        }

                        to {
                            margin-left: 20%;
                            width: 100%;
                         }
                      }
			.island{
                           animation-duration: 20s;
                           animation-name: fadeIN;
                           animation-iteration-count: infinite;
                           animation-direction: alternate;
                           }
			   @keyframes fadeIN {
                           from {
                           margin-left: 50%;
                           width: 300%;
                        }

                        to {
                            margin-left:5%;
                            width: 150%;
                         }
                      }
		
						
		</style>
	    
	    <div class="island">   <p><strong> St Thomas</strong> is a lively island boasting an impressive reef edge.
                    <p> The island offers the natural beauty of the islands with a sophisticated and cosmopolitan atmosphere.
                     The perfect place for sea turtles and lobsters to call home
		     <strong>Carvel Rock </strong>is a must for divers to explore on St. Johns.
                     Often referred to as a drift dive keep an eye out for sting rays, nurse sharks, octopus 
                     passing by you.
                     The diversity of the US Virgin Islands means that vacationers and divers a like
	             will find a vacation of their dreams 	   	  
	             The currency of the US Virgin Islands is the US Dollar.      
		     Major credit cards are accepted in almost all - but not all - establishments.
                     Ask before you make a purchase or order food.	 
		     ATM machines are located in banks and at other commercial locations.
		     There is a free-standing ATM machine on the West Indian Company Cruise Ship Dock next to the Welcome Center.</p>	    
	    
	    
	    
	    
	    </div>
	    
		
    </head>
    <body>
         
  <script> 
  var colorEL= document.getElementById("summer");
  colorEl.style.color = "green";
  
  
  
  </script>
   
   
  
 
                 
      
        
       
        
    </body>
</html>

