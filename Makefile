.PHONY: dotnet

dotnet:
	@docker-compose up -d --build generate-avsc
	@docker-compose up -d --build generate-dotnet
	@docker-compose down