# How to connect to the Orion API

## Initialize OrionConnect with a config hash
# config_hash = {}
# config_hash["base_url"] = 'https://testapi.orionadvisor.com/api/v1'
# config_hash["user"] = 'demo_user'
# config_hash["password"] = 'demo_password'

# orion_connect = OrionConnect.new(config_hash)

## Perform a get request
# orion_connect.perform_get('endpoint_url')

## Perform a post request
# orion_connect.perform_post('endpoint_url', params)

require 'rest_client'
require 'rexml/document'

class OrionConnect
  def initialize(config)
    @resource = generate_resource(config)
  end

  def get_access_token(base_url, user, password)
    url = base_url + '/security/token'
    request = RestClient::Request.new( :url => url, :method => :get, :user => user, :password => password )
    response = request.execute

    doc = REXML::Document.new(response.body)
    access_tokens = []
    doc.elements.each('JwtToken/access_token') { |ele| access_tokens << ele.text }
    access_token = access_tokens.first
    access_token
  end

  def generate_resource(config)
    base_url, user, password = config["base_url"] ,config["user"], config["password"]

    access_token = get_access_token(base_url, user, password)
    puts "API access token: #{access_token}"

    auth = 'Session ' + access_token
    resource = RestClient::Resource.new( base_url, :headers => {:authorization => auth } )
    return resource
  end

  def perform_get(path)
    response = @resource[path].get(:accept => 'json')
    return JSON.parse response
  end

  def perform_post(path, params)
    response = @resource[path].post(
      params.to_json, :content_type => :json, :accept => 'json')
    return JSON.parse response
  end
end
