<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Berwyn Bus Hire</title>
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
        </style>
    </head>
    <body>
        <img src="bus-banner.jpg"><br>
        <form>

        <div class="btn-group" style="width:100%">
            <button style="width:16.3%">Home</button>
            <button style="width:16.3%">Vehicles</button>
            <button style="width:16.3%"><a href="bookingvehicle.html">Booking</a></button>
            <button style="width:16.3%"><a href="basket.html">Shopping Cart</a></button>
            <button style="width:16.3%"><a href="about.php">About Us</a></button>
            <button style="width:16.3%"><a href="contact.php">Contact</a></button>
        <div>
            
        <table>
            <thead>
                <tr>
                    <th>Vehicle ID</th>
                    <th>Model ID</th>

                </tr>
            </thead>
            <tbody>
                <?php foreach ($results as $booking): ?>
                <tr>
                    <td><?= $booking->VehicleID ?></td>
                    <!-- <td><?= $booking->ModelID?></td> -->
                </tr>
                <?php endforeach ?>
            </tbody>
        </table>

        <div class="footer">
            <p>Berwyn Bus Hire Company Ltd</p>
            <p>K1602155 / K1834977 / K1524638 / K1823571 / K1515883</p>
        </div>
        </form>
    </body>
</html>