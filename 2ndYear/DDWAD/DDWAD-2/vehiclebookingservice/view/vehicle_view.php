<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Berwyn Bus Vehicles</title>

       
        <style>
            .footer {
                position: fixed;
                left: 0;
                bottom: 0;
                width: 100%;
                background-color: grey;
                color: black;
                text-align: center;
            }

             form.example input[type=text] {
                padding: 10px;
                font-size: 17px;
                border: 1px solid grey;
                float: left;
                width: 80%;
                background: #f1f1f1;
            }   

        form.example button {
                float: left;
                width: 20%;
                padding: 10px;
                background: #2196F3;
                color: white;
                font-size: 17px;
                border: 1px solid grey;
                border-left: none;
                cursor: pointer;
        }

        form.example button:hover {
                background: #0b7dda;
        }

        form.example::after {
                content: "";
                clear: both;
                display: table;
        }
        </style>
    </head>

<body style = "background-color:beige;">
    <img src="bus-banner.jpg"><br>

    <form>

        <div class="btn-group" style="width:100%">
            <button style="width:16.3%">Home</button>
            <button style="width:16.3%">Vehicles</button>
            <button style="width:16.3%">Booking</button>
            <button style="width:16.3%">Shopping Cart</button>
            <button style="width:16.3%">About Us</button>
            <button style="width:16.3%">Contact</button>
        <div>

    <form class="example" action="/action_page.php" style="margin:auto;max-width:300px">
            
            <input type="text" placeholder="Search..." name="search">
            <button type="submit"><i class="fa fa-search">Search</i></button><br><br><br><br>
    </form>

       <ul>

                <li><a href ="../view/index.php">Home</a></li>
                <li><a href ="../view/vehicle_view.php">Vehicles</a></li>
                <li><a href ="../view/about.php">About</a></li>
                <li><a href ="../view/contact.php">Contact</a></li>
        </ul>

        <h1> Berwyn Bus Hire Ltd </h1>

        <a href = "register.html">Register</a>
        <a href = "loginpage.html">/ Login</a> <br>

        <img src= "https://smccoachhire.com/wp-content/uploads/shutterstock_30656347-500x334.jpg?x97416" alt = "Car Rental poster" style = "width:500px;height:600px;"> <br>
        
        <form method="post" action="studentlist.php">
            Search for Vehicle by cost:
            <input name="search"/>
            <input type="submit"value"Search"/>
        </form>
                
        <p1> Below is a list of all of our vehicles and all the details needed for it </p1> <br>
        <tr>
        
        <table>
            <thead>
                <tr>
                    <th>Vehicle ID</th>
                    <th>Model ID</th>
                    <th>Model Name</th>
                    <th>Passenger Limit</th>

                </tr>
            </thead>
            <tbody>
                <?php require_once "../controller/vehicle_list.php"; 
                require_once "../controller/vehicle_model.php";
                foreach ($VehicleResults as $vehicle): ?>
                <tr>
                    <td><?= $vehicle->VehicleID ?></td>
                    <td><?= $vehicle->ModelID?></td>
                    <td>
                </tr>
                <?php endforeach ?>
            </tbody>
        </table>
        <br>

        <div class="footer">
            <p>Berwyn Bus Hire Company Ltd</p>
            <p>K1602155 / K1834977 / K1524638 / K1823571 / K1515883</p>
        </div>
    </form>

</body>
<footer>

</footer>