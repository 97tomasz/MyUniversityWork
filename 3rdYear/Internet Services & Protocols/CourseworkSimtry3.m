clc;
clear all;

%RSRT = randperm(96,96)-140;
%RSRS = randperm(96,96)-140;
a=randi(2,[1,1951])-1;
a(~a)=-1;
b =randi(2,[1,1951])-1;
b(~b)=-1;
RSRT=linspace(-44,-92,49);
RSRT=[RSRT,a];
RSRS=linspace(-140,-92,49);
z=0;
for x=1:length(b)
    for y=1:length(RSRS)
        z=z+1;
    end
    temp1=RSRS(z);
    temp2=b(x);
    temp3=update(temp1,temp2);
    RSRS=[RSRS, temp3];
end
HOTrigger=0;
title('Power Budget Handover Algorithm')
xlabel('Time elapsed (ms)')
ylabel('Refernce Signal Received Power (dB)')
hold on;
HOM=(-5:15);
TTT=(10:10:120);
s=2000;
for j=1:length(HOM)
for i=1:length(RSRT)
    if RSRT(i)>RSRS(i)+HOM(j)
    plot(RSRT);
    hold on;
    plot(RSRS);
    end
end
end
