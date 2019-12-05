clc
clear all
unitsMoved = [2500 4000 3500 490];
hourlyRate = 30;
hoursWorked = [3.2 4.1 5.0 5.6];

basic = hoursWorked .* hourlyRate;
commission = unitsMoved .* 0.01;
wages = basic + commission;

subplot(4,1,1), plot(unitsMoved, 'r--*')
subplot(4,1,2), plot(commission, 'b--o')
subplot(4,1,3), plot(wages, 'g-^')
subplot(4,1,4), plot(basic,'r--*')
hold on
subplot(4,1,4), plot(wages,'g-^')
hold off