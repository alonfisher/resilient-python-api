#!/usr/bin/env python

"""Global accessor for the Resilient REST API"""

import co3
import logging

LOG = logging.getLogger(__name__)
resilient_client = None
connection_opts = None


def reset_resilient_client():
    """Reset the cached client"""
    global resilient_client
    resilient_client = None


def get_resilient_client(opts):
    """Get a connected instance of SimpleClient for Resilient REST API"""
    global resilient_client
    global connection_opts

    new_opts = (opts.get("cafile"),
                opts.get("org"),
                opts.get("host"),
                opts.get("port"),
                opts.get("proxy"),
                opts.get("email"))
    if new_opts != connection_opts:
        resilient_client = None
        connection_opts = new_opts
    if resilient_client:
        return resilient_client

    return co3.get_client(opts)

