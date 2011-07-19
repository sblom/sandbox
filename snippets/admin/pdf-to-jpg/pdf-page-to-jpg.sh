pdftk mailscan.pdf cat 4 output check1-front.pdf
convert -density 200 check1-front.pdf -colorspace Gray check1-front.jpg
