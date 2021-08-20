FROM mcr.microsoft.com/dotnet/sdk:5.0

# Add keys and sources lists
RUN curl -sL https://deb.nodesource.com/setup_12.x | bash
RUN curl -sS https://dl.yarnpkg.com/debian/pubkey.gpg | apt-key add -
RUN echo "deb https://dl.yarnpkg.com/debian/ stable main" \
    | tee /etc/apt/sources.list.d/yarn.list

# Install node, 7zip, yarn, git, process tools
RUN apt-get update \
    && apt-get install -y nodejs p7zip-full yarn git procps libgdiplus

# Install google-chrome for Canopy/Selenium
RUN wget https://dl.google.com/linux/direct/google-chrome-stable_current_amd64.deb \
    && apt install -y ./google-chrome-stable_current_amd64.deb \
    && sed -i 's,HERE/chrome",& --no-sandbox ,' /opt/google/chrome/google-chrome \
    && rm -f google-chrome-stable_current_amd64.deb

# Clean up
RUN apt-get autoremove -y \
    && apt-get clean -y \
    && rm -rf /var/lib/apt/lists/*

# Install dotnet tools
RUN dotnet tool install fable -g
RUN dotnet tool install fantomas-tool -g
RUN dotnet tool install paket -g
RUN dotnet tool install fake-cli -g

# Trouble brewing
RUN rm /etc/ssl/openssl.cnf

# add dotnet tools to path to pick up fake and paket installation
ENV PATH="/root/.dotnet/tools:${PATH}"

# Copy endpoint specific user settings into container to specify
# .NET Core should be used as the runtime.
COPY settings.vscode.json /root/.vscode-remote/data/Machine/settings.json
