import urllib.request
import urllib.parse
import json
from pymongo import MongoClient

# Open connection to mongo
connstr = 'mongodb://127.0.0.1:27017'
client = MongoClient(connstr)

# Create db
db_name = 'weather'
client.drop_database(db_name)
db = client[db_name]

# Get city names
url = 'https://restcountries.eu/rest/v2/all'
response = urllib.request.urlopen(url)
data = response.read().decode('utf-8')
countries = json.loads(data)
city_names = [ country['capital'] for country in countries]
city_names.sort()

# Insert cities collection
cities = [ { "name": name } for name in city_names if name ] 
db.cities.insert_many(cities)

# All other collections are empty
