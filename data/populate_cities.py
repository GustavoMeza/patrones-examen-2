import csv

# http://download.geonames.org/export/dump/cities15000.zip 

with open('cities15000.txt') as file:
    rows = csv.reader(file, delimiter='\t') 
    cities = [ obj[1] for obj in rows if int(obj[14]) > 500000 ]

cities.sort()

with open('cities.txt', 'w') as file:
    for city in cities:
        file.write('%s\n'%city)

