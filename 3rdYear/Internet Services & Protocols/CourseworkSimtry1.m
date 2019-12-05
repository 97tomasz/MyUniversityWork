clc;
clear all;
close all;

X_Center(1)=0;
Y_Center(1)=0;

R=2; %cell radius
N=3; %number of cells
D=R*sqrt(N); %distance between two centers of Cells
t=0:pi/3:2*pi; %angles of hexagon
Hexa_x_1=X_Center(1)+R*cos(t);
Hexa_y_1=Y_Center(1)+R*sin(t);
figure
hold on;
plot(Hexa_x_1,Hexa_y_1,'r');
fill(Hexa_x_1,Hexa_y_1,[0.8,0.7,0.5]);
N=2; %number of interfering cells
Directions=[30:60:360]; %interfering cells are 60 degrees from center

%plot intersecting hexagons

for i=2 : (N+1)
    X_Center(i)=X_Center(1)+D*cosd(Directions(i));
    Y_Center(i)=Y_Center(1)+D*sind(Directions(i));
    x=X_Center(i)+R*cos(t);
    y=Y_Center(i)+R*sin(t);
    plot(x,y);
    fill(x,y,[0.8,0.7,0.5]);
end

Channel_Number=100;
Channel_Number_x=floor(channel_Number/(N+1));

Previous_time=clock;
Dropped_Call=0;
Call_Initiated=0;
while etime(clock, Previous_Time)<10
    User_Probability=rand(1); %probability of success user
    User_Cell_Position=floor((4-1)*rand(1)+1);