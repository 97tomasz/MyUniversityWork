clc
clear all
rng1 = 0;
rng2 = 20;
a = (rng2-rng1).*rand(1,1) + rng1;
if a > 15 
    b = a
elseif a < 10
    c = a
elseif a > 5 
    d = a
end
