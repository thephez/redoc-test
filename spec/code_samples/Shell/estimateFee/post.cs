curl --request POST \
  --url http://dapi-testnet.thephez.com:3999/estimateFee \
  --header 'content-type: application/json' \
  --data '{"method":"estimateFee","id":1,"jsonrpc":"2.0","params":{"blocks":1}}'
