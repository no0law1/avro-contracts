## FROM avdl to avsc
FROM openjdk:11 as build

WORKDIR /home/avro-gen

COPY ./avdl ./avdl

# Where to get this url?
RUN curl -L -o /avro-tools.jar https://repo1.maven.org/maven2/org/apache/avro/avro-tools/1.10.0/avro-tools-1.10.0.jar

CMD java -jar /avro-tools.jar idl2schemata $(find ./avdl -name "*.avdl" -printf "%p ") ./avsc

## FROM avsc to dotnet
FROM mcr.microsoft.com/dotnet/sdk:3.1-focal as runtime

COPY ./avsc /home/avro-gen/avsc

WORKDIR /home/avro-gen

RUN apt-get update && \
    apt-get install -y openjdk-11-jdk && \
    apt-get install -y ant && \
    apt-get clean;

ENV JAVA_HOME /usr/lib/jvm/java-11-openjdk-amd64/
RUN export JAVA_HOME

ENV PATH "{$PATH}:/usr/lib/jvm/java-11-openjdk-amd64/:/root/.dotnet/tools"
RUN export PATH

RUN dotnet tool install -g Apache.Avro.Tools --version 1.11.0

CMD avrogen -s $(find ./avsc -name "*.avsc" -printf "%p ") ./dotnet