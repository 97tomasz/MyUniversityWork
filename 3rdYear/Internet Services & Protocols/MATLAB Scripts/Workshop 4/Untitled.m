clear all
clc
num_bits = 100000;
data=randi([0,1], num_bits, 1);
a=2*data-1;
SNRdB=0:2:30;
SNR=10.^(SNRdB/10);

for k=1:length(SNRdB)
    SNR
    y=a+awgn(a,SNRdB(k));
    error=0;
    for (c=1:1:num_bits)
        if (y(c)>0&&data(c)==0)||(y(c)<0&&data(c)==1)
            error = error +1;
        end
    end
    error=error/num_bits;
    m(k)=error;
end