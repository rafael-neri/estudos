def count_bits(n)
    n.to_s(2).scan(/1/).length
end
