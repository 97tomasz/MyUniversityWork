clear all
clc
for i=-100:100
    datastream = randi([0,1],1,100000);
    M = 8;
    N = 8;
    error=0;
    q=10;
    p = qammod(datastream, M)
    channel_awgm=awgn(p,q);
    d = qamdemod(channel_awgm, N)
    for i=1:length(datastream)
        if d(i) ~= datastream(i)
            error = error+1;
        end
    end
end
error = error/length(datastream) * 100;

%generate 100000 bits
%use different orders of modulation using qammod/qamdemod only (4, 16, 32)
%using a for loop SNR 0:2:30
%calculate the bit error rate using logical operations
%READ: rayleigh fading channel