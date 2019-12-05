clc
%clear all
rng1 = 0;
rng2 = 20;
a = (rng2-rng1).*rand(4,4) + rng1;

for i=1:4
    for j =1:4
    a(i,j) = 10;
    end
end
a