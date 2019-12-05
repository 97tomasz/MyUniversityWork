clc;
clear all;

%RSRT = randperm(96,96)-140;
%RSRS = randperm(96,96)-140;
RSRT=linspace(-44,-140,97);
RSRS=linspace(-140,-44,97);
HOM=(-5:5);
TTT=(10:10:40);
results = zeros(1,length(HOM));
s=2000;
HOTrigger=0;
for k=1:length(TTT)
    title('Power Budget Handover Algorithm')
    xlabel('Time elapsed (ms)')
    ylabel('Refernce Signal Received Power (dB)')
    hold on;
for j=1:length(HOM)
for i=1:length(RSRT)
    trueOrFalse=0;
    if RSRT(i)>RSRS(i)+HOM(j)
        HOTrigger+1;
        plot(RSRT(i))
        if HOTrigger>=TTT(k)
            trueOrFalse=1;
        end
        if trueOrFalse==1
            results(j)=1;
        end
    else
        HOTrigger=0;
    end
end 

end
    plot(RSRT);
    plot(RSRT+HOM(j));
    hold on;
    plot(RSRS);
    hold off;
    figure();
end
